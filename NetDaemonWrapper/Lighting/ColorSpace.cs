using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NetDaemonWrapper.Lighting
{
    public static class ColorSpace
    {
        private static double gamma = 2.2;
        private static double inversegamma = 1 / gamma;

        public static double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                inversegamma = 1 / gamma;
            }
        }

        private static int[] PowerLUT;
        private static int[] VisualLUT;

        static ColorSpace()
        {
            BuildLUT();
        }

        public static void BuildLUT()
        {
            PowerLUT = new int[65536];
            VisualLUT = new int[65536];

            Task BuildPowerLUT = Task.Run(() =>
            {
                for (int i = 0; i < 65535; i++)
                {
                    PowerLUT[i] = ToPower(i);
                }
            });

            Task BuildVisualLUT = Task.Run(() =>
            {
                for (int power = 0; power < 65535; power++)
                {
                    VisualLUT[power] = ToVisual(power);
                }
            });

            BuildPowerLUT.Wait();
            BuildVisualLUT.Wait();
        }

        /// <summary>
        /// Convert from Linear Visual space to Linear Power space.
        /// </summary>
        /// <param name="PerceptionValue"></param>
        /// <returns></returns>
        public static int ToPower(int PerceptionValue)
        {
            double powerOut = (double)PerceptionValue / 65535;
            powerOut = Math.Pow(powerOut, gamma);
            powerOut *= 65535;
            return (int)powerOut;
        }

        public static int ToPowerFast(int PerceptionValue)
        {
            return PowerLUT[Math.Clamp(PerceptionValue, 0, 65535)];
        }

        /// <summary>
        /// Convert from Linear Power space to Linear Visual space.
        /// </summary>
        /// <param name="Power"></param>
        /// <returns></returns>
        public static int ToVisual(int Power)
        {
            double powerOut = (double)Power / 65535;
            powerOut = Math.Pow(powerOut, inversegamma);
            powerOut *= 65535;
            return (int)powerOut;
        }

        public static int ToVisualFast(int Power)
        {
            return VisualLUT[Math.Clamp(Power, 0, 65535)];
        }
    }

    /// <summary>
    /// HDR16 color in linear perception space
    /// </summary>
    public class FullColor
    {
        public int r16;
        public int g16;
        public int b16;
        public int a8;

        public PowerColor powerColor
        {
            get
            {
                return new PowerColor(this);
            }
        }

        public FullColor()
        {
            r16 = 0;
            g16 = 0;
            b16 = 0;
            a8 = 255;
        }

        public FullColor(Color _color, byte _brightness) : this(_color.R, _color.G, _color.B, _brightness, _color.A)
        {
        }

        public FullColor(ColorBright _ColorBright, byte _alpha) : this(_ColorBright.r, _ColorBright.g, _ColorBright.b, _ColorBright.brightness, _alpha)
        {
        }

        public FullColor(byte _red, byte _green, byte _blue, byte _brightness, byte _alpha)
        {
            r16 = _red * _brightness;
            g16 = _green * _brightness;
            b16 = _blue * _brightness;
            a8 = _alpha;
        }

        public FullColor(PowerColor powerSpace)
        {
            r16 = ColorSpace.ToVisualFast(powerSpace.r16);
            g16 = ColorSpace.ToVisualFast(powerSpace.g16);
            b16 = ColorSpace.ToVisualFast(powerSpace.b16);
            a8 = powerSpace.a8;
        }

        public static FullColor Blend(FullColor a, FullColor b, BlendMode mode)
        {
            return new FullColor(PowerColor.Blend(a.powerColor, b.powerColor, mode));
        }

        public ColorBright toColorBright()
        {
            int max = Math.Max(r16, Math.Max(g16, b16)); //Get Maximum Value
            ColorBright output = new ColorBright();
            if (max > 0)
            {
                //Max of these 3 should be 255
                output.r = (byte)(r16 * 255 / max);
                output.g = (byte)(g16 * 255 / max);
                output.b = (byte)(b16 * 255 / max);
                //This should be the Max / 256. So (65535, 65535, 65535) should become (255, 255, 255) & 255 brightness after round-down
                output.brightness = (byte)(max >> 8);
                return output;
            }
            else
            {
                return ColorBright.Black;
            }
        }
    }

    /// <summary>
    /// HDR16 color in linear power space
    /// </summary>
    public class PowerColor
    {
        public int r16;
        public int g16;
        public int b16;
        public int a8;

        public FullColor fullColor
        {
            get
            {
                return new FullColor(this);
            }
        }

        public PowerColor(FullColor visualSpace)
        {
            r16 = ColorSpace.ToPowerFast(visualSpace.r16);
            g16 = ColorSpace.ToPowerFast(visualSpace.g16);
            b16 = ColorSpace.ToPowerFast(visualSpace.b16);
            a8 = visualSpace.a8;
        }

        public PowerColor()
        {
            r16 = 0;
            g16 = 0;
            b16 = 0;
            a8 = 255;
        }

        /// <summary>
        /// Blends values and returns flattened (opaque) FullColor
        /// </summary>
        /// <param name="top">FullColor + Alpha Source</param>
        /// <param name="bottom">FullColor</param>
        /// <param name="mode">Blending Method</param>
        /// <returns></returns>
        public static PowerColor Blend(PowerColor top, PowerColor bottom, BlendMode mode)
        {
            switch (mode)
            {
                case BlendMode.Add:
                    return Add(top, bottom);

                case BlendMode.Multiply:
                    return Multiply(top, bottom);

                case BlendMode.Alpha:
                    return Alpha(top, bottom);
            }
            return top;
        }

        private static PowerColor Multiply(PowerColor a, PowerColor b)
        {
            PowerColor result = new PowerColor();
            result.r16 = (a.r16 * b.r16) >> 16;
            result.g16 = (a.g16 * b.g16) >> 16;
            result.b16 = (a.b16 * b.b16) >> 16;
            return result;
        }

        private static PowerColor Add(PowerColor a, PowerColor b)
        {
            PowerColor result = new PowerColor();
            result.r16 = Math.Clamp(a.r16 + b.r16, 0, 65535);
            result.g16 = Math.Clamp(a.g16 + b.g16, 0, 65535);
            result.b16 = Math.Clamp(a.b16 + b.b16, 0, 65535);
            return result;
        }

        private static PowerColor Alpha(PowerColor a, PowerColor b)
        {
            PowerColor result = new PowerColor();
            result.r16 = ((a.r16 * a.a8) + (b.r16 * (255 - a.a8))) >> 8;
            result.g16 = ((a.g16 * a.a8) + (b.g16 * (255 - a.a8))) >> 8;
            result.b16 = ((a.b16 * a.a8) + (b.b16 * (255 - a.a8))) >> 8;
            return result;
        }
    }

    /// <summary>
    /// Structure for rgbb8 final render to light.
    /// </summary>
    public class ColorBright
    {
        public byte r;
        public byte g;
        public byte b;
        public byte brightness;

        public Color color
        {
            get
            {
                return Color.FromArgb(r, g, b);
            }
            set
            {
                r = value.R;
                g = value.G;
                b = value.B;
            }
        }

        public static readonly ColorBright Black = new ColorBright() { r = 0, g = 0, b = 0, brightness = 0 };
        public static readonly ColorBright White = new ColorBright { r = 255, g = 255, b = 255, brightness = 255 };
    }

    public enum BlendMode
    { None, Alpha, Add, Multiply }
}