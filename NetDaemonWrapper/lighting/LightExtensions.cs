using NetDaemon.AppModel;
using NetDaemon.HassModel;
using HomeAssistantGenerated;
using System.Drawing;

namespace NDWrapper.Lighting
{
    public static class LightExtensions
    {
        public static void Set(this LightEntity _light, int _brightness, Color _color)
        {
            if (_color == Color.Black || _brightness == 0)
            {
                _light.TurnOff();
                return;
            }
            var color = new int[] { _color.R, _color.G, _color.B };
            _light.TurnOn(rgbColor: color);
        }

        public enum BlendMode
        { none, alpha, add, multiply }

        public static Color Blend(BlendMode blendMode, Color color1, Color color2)
        {
            int r = 0, g = 0, b = 0;
            switch (blendMode)
            {
                case BlendMode.none:
                    return color1;

                case BlendMode.alpha:
                    r = Alpha(color1.R, color2.R, color1.A);
                    g = Alpha(color1.G, color2.G, color1.A);
                    b = Alpha(color1.B, color2.B, color1.A);
                    break;

                case BlendMode.add:
                    r = Clamp(color1.R + color2.R);
                    g = Clamp(color1.G + color2.G);
                    b = Clamp(color1.B + color2.B);
                    break;

                case BlendMode.multiply:
                    r = Multiply(color1.R, color2.R);
                    g = Multiply(color1.G, color2.G);
                    b = Multiply(color1.B, color2.B);
                    break;
            }

            return Color.FromArgb(r, g, b);
        }

        public static int Clamp(int value)
        {
            return (value < 0) ? 0 : (value > 255) ? 255 : value;
        }

        public static int Alpha(float A, float B, float Alpha)
        {
            if (Alpha == 255) return (int)A;
            if (Alpha == 0) return (int)B;
            Alpha = Clamp((int)Alpha);
            return (int)(((A * Alpha) + (B * (255 - Alpha))) / 255.0);
        }

        public static int Multiply(int A, int B)
        {
            return Clamp(A * B / 255);
        }
    }
}