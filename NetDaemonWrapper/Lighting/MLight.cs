using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using NetDaemonWrapper;

namespace NetDaemonWrapper.Lighting
{
    public class MLight
    {
        public static List<MLight> All = new List<MLight>();
        public LightEntity entity;
        public readonly Area? Room = null;
        private static SettingsFile settings = new SettingsFile("Lighting/LightConfig.xml");
        public readonly coords Location;

        private ColorBright currentState = new ColorBright();
        private bool isChanged = false;
        public float transition = 1;
        public int SceneIdentifier = 0;

        public MLightLayer Base = new MLightLayer();
        public MLightLayer Theme = new MLightLayer();
        public MLightLayer Custom = new MLightLayer();
        public MLightLayer Anim = new MLightLayer();
        public readonly List<MLightLayer> Layers;

        public MLight(IHaContext _ha, LightEntity _entity)
        {
            entity = _entity;
            Layers = new List<MLightLayer>()
            {
                Base,
                Theme,
                Custom,
                Anim
            };

            Room = _ha.GetAreaFromEntityId(entity.EntityId);

            Location = new coords(
                int.Parse(settings.ReadSetDefault(entity.EntityId, "North_Inches", "0")),
                int.Parse(settings.ReadSetDefault(entity.EntityId, "West_Inches", "0")),
                int.Parse(settings.ReadSetDefault(entity.EntityId, "Height_Inches", "0")));

            All.Add(this);
        }

        public static MLight byName(string name)
        {
            return MLight.All.First(l => l.entity.EntityId == name);
        }

        /// <summary>
        /// If changes are present, display updated value on final light.
        /// </summary>
        public void Show()
        {
            if (isChanged)
            {
                entity.Set(currentState, transition);
            }
        }

        private bool isEqual(ColorBright s)
        {
            bool same = true;
            same &= currentState.r == s.r;
            same &= currentState.g == s.g;
            same &= currentState.b == s.b;
            same &= currentState.brightness == s.brightness;
            return same;
        }

        /// <summary>
        /// Blends and flattens layers into a final state ready to display. Designed to run in parallel.
        /// </summary>
        public void ProcessState()
        {
            ColorBright newState = Flatten();
            if (isEqual(newState)) //Avoid unnecessary reassertions. Remove this if lights fail to update.
            {
                isChanged = false;
                return;
            }
            isChanged = true;
            currentState = newState;
        }

        public void UpdateNow()
        {
            ProcessState();
            Show();
        }

        public void Set(Layer _layer, FullColor _color, float transition)
        {
            switch (_layer)
            {
                case Layer.Anim:
                    Anim.transition = transition;
                    Anim.color = _color;
                    Anim.isActive = true;
                    break;

                case Layer.Custom:
                    Custom.transition = transition;
                    Custom.color = _color;
                    Custom.isActive = true;
                    break;

                case Layer.Theme:
                    Theme.transition = transition;
                    Theme.color = _color;
                    Theme.isActive = true;
                    break;

                case Layer.Base:
                    Base.transition = transition;
                    Base.color = _color;
                    break;
            }
        }

        public void Set(Layer _layer, FullColor _color)
        {
            Set(_layer, _color, 1);
        }

        private ColorBright Flatten()
        {
            List<MLightLayer> activeLayers = new List<MLightLayer>();

            //Check top to bottom for all layers that affect result
            for (int i = Layers.Count - 1; i >= 0; i--)
            {
                if (Layers[i].isActive)
                {
                    activeLayers.Insert(0, Layers[i]); //Add to the list of relevant layers.

                    if ((Layers[i].blendMode == BlendMode.Alpha && Layers[i].color.a8 >= 255) || (Layers[i].blendMode == BlendMode.None))
                    {
                        break; //If both active and opaque, we have found the bottom-most layer. Any additional layers will be obscured by this one.
                    }
                }
                else if (i == 0)
                {
                    activeLayers.Insert(0, Layers[i]);
                }
            }

            if (activeLayers.Count == 0)
            {
                transition = Base.transition;
                return Base.color.toColorBright(); //Top and bottom are the same layer. No blending necessary.
            }

            if (activeLayers.Count == 1)
            {
                transition = activeLayers[0].transition;
                return activeLayers[0].color.toColorBright();
            }

            //Operations below are performed in linear power space.
            PowerColor colorOut = activeLayers[0].color.powerColor; //Apply bottom layer here

            //Now we must blend layers bottom-to-top. Start at the second-from-bottom layer and blend with the bottom.
            for (int i = 1; i <= activeLayers.Count - 1; i++)
            {
                colorOut = PowerColor.Blend(activeLayers[i].color.powerColor, colorOut, activeLayers[i].blendMode);
            }
            transition = activeLayers[activeLayers.Count - 1].transition;
            return colorOut.fullColor.toColorBright();
        }
    }

    public enum Layer
    { Base, Theme, Custom, Anim };

    public class MLightLayer
    {
        public MLightLayer()
        {
            color = new FullColor();
            isActive = false;
            brightness = 0;
        }

        public MLightLayer(MLightLayer clone)
        {
            color = clone.color;
            isActive = clone.isActive;
            brightness = clone.brightness;
        }

        public float transition = 1;
        public FullColor color;

        /// <summary>
        /// Layer is active
        /// </summary>
        public bool isActive;

        public int brightness;
        public BlendMode blendMode = BlendMode.None;
    }

    public class coords
    {
        public int N_in;
        public int W_in;
        public int H_in;
        private static int N_Max;
        private static int W_Max;
        private static int H_Max;

        public double N_rel
        { get { return (double)N_in / N_Max; } }

        public double W_rel
        { get { return (double)W_in / W_Max; } }

        public double H_rel
        { get { return (double)H_in / H_Max; } }

        public coords(int North_Inches, int West_Inches, int Height_Inches)
        {
            N_in = North_Inches;
            W_in = West_Inches;
            H_in = Height_Inches;
            N_Max = Math.Max(N_Max, N_in);
            W_Max = Math.Max(W_Max, W_in);
            H_Max = Math.Max(H_Max, H_in);
        }
    }
}