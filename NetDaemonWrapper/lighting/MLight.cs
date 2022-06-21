using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using NDExtensions;

namespace NDManagers
{
    using static LightExtensions;

    internal class MLight
    {
        public LightEntity entity;
        public MLightLayer Base = new MLightLayer();
        public MLightLayer Theme = new MLightLayer();
        public MLightLayer Custom = new MLightLayer();
        public MLightLayer Anim = new MLightLayer();
        public List<MLightLayer> Layers;

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

        private void Show()
        {
            Console.WriteLine("Show " + entity.EntityId);
            SetLightEntity(getShowState());
        }

        public void Set(Layer layer, Color color, int brightness)
        {
            var oldstate = new MLightLayer(getShowState()); //Must create copy

            switch (layer)
            {
                case Layer.Anim:
                    Anim.color = color;
                    Anim.brightness = brightness;
                    Anim.isActive = true;
                    break;

                case Layer.Custom:
                    Custom.color = color;
                    Custom.brightness = brightness;
                    Custom.isActive = true;
                    break;

                case Layer.Theme:
                    Theme.color = color;
                    Theme.brightness = brightness;
                    Theme.isActive = true;
                    break;

                case Layer.Base:
                    Base.color = color;
                    Base.brightness = brightness;
                    break;
            }

            var newstate = getShowState();
            Console.WriteLine("Old " + oldstate.color.ToString());
            Console.WriteLine("New " + newstate.color.ToString());

            Show();
        }

        private void SetLightEntity(MLightLayer layer)
        {
            entity.Set(layer.brightness, layer.color);
        }

        private MLightLayer getShowState()
        {
            int top = 0;
            int bottom = Layers.Count - 1;
            for (int i = 0; i < Layers.Count; i++)
            {
                if (Layers[i].isActive)
                {
                    top = i;
                    if (Layers[i].color.A == 255)
                    {
                        bottom = i;
                    }
                }
            }
        }
    }

    internal enum Layer
    { Base, Theme, Custom, Anim };

    internal class MLightLayer
    {
        public MLightLayer()
        {
            color = Color.Black;
            isActive = false;
            brightness = 0;
        }

        public MLightLayer(MLightLayer clone)
        {
            color = clone.color;
            isActive = clone.isActive;
            brightness = clone.brightness;
        }

        public Color color;
        public bool isActive;
        public int brightness;
        public BlendMode blendMode = BlendMode.none;
    }
}