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
    internal class MLight
    {
        public LightEntity entity;
        public MLightLayer Base = new MLightLayer();
        public MLightLayer Theme = new MLightLayer();
        public MLightLayer Custom = new MLightLayer();
        public MLightLayer Anim = new MLightLayer();
        public List<MLightLayer> Layers;

        private ColorBright currentState = new ColorBright();
        private bool isChanged = false;

        public MLight(LightEntity _entity)
        {
            entity = _entity;
            Layers = new List<MLightLayer>()
            {
                Base,
                Theme,
                Custom,
                Anim
            };
        }

        /// <summary>
        /// If changes are present, display updated value on final light.
        /// </summary>
        public void Show()
        {
            if (isChanged)
            {
                entity.Set(currentState);
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

        public void Set(Layer _layer, FullColor _color)
        {
            switch (_layer)
            {
                case Layer.Anim:
                    Anim.color = _color;
                    Anim.isActive = true;
                    break;

                case Layer.Custom:
                    Custom.color = _color;
                    Custom.isActive = true;
                    break;

                case Layer.Theme:
                    Theme.color = _color;
                    Theme.isActive = true;
                    break;

                case Layer.Base:
                    Base.color = _color;
                    break;
            }
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

                    if (Layers[i].blendMode == BlendMode.Alpha && Layers[i].color.a8 >= 255)
                    {
                        break; //If both active and opaque, we have found the bottom-most layer. Any additional layers will be obscured by this one.
                    }
                }
                if (i == 0)
                {
                    activeLayers.Insert(0, Layers[i]);
                }
            }

            if (activeLayers.Count == 0)
            {
                return Base.color.toColorBright(); //Top and bottom are the same layer. No blending necessary.
            }

            if (activeLayers.Count == 1)
            {
                return activeLayers[0].color.toColorBright();
            }

            //Operations below are performed in linear power space.
            PowerColor colorOut = activeLayers[0].color.powerColor; //Apply bottom layer here

            //Now we must blend layers bottom-to-top. Start at the second-from-bottom layer and blend with the bottom.
            for (int i = 1; i <= activeLayers.Count - 1; i++)
            {
                colorOut = PowerColor.Blend(activeLayers[i].color.powerColor, colorOut, activeLayers[i].blendMode);
            }

            return colorOut.fullColor.toColorBright();
        }
    }

    internal enum Layer
    { Base, Theme, Custom, Anim };

    internal class MLightLayer
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

        public FullColor color;
        public bool isActive;
        public int brightness;
        public BlendMode blendMode = BlendMode.None;
    }
}
