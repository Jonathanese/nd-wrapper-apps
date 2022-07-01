using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper.Lighting;

namespace NetDaemonWrapper.Scene
{
    public static partial class Scenes
    {
        public static Scene NightLight = new Scene("night_light", () =>
        {
            foreach (MLight l in MLight.All)
            {
                l.Theme.blendMode = BlendMode.Alpha;
                l.Set(Layer.Theme, FullColor.Black);
            }
        });

        public static Scene NormalLights = new Scene("normal_lights", () =>
        {
            foreach (MLight l in MLight.All)
            {
                l.Theme.isActive = false;
            }
        });
    }
}