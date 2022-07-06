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
        public static Scene NightLight = new Scene("night_light", (Lights) =>
        {
            foreach (MLight l in Lights)
            {
                l.Theme.blendMode = BlendMode.Alpha;
                l.Set(Layer.Theme, FullColor.Black);
            }
        });

        public static Scene NormalLights = new Scene("normal_lights", (Lights) =>
        {
            foreach (MLight l in Lights)
            {
                l.Theme.isActive = false;
            }
        });

        public static Scene RandomColors = new Scene("random_colors", 10, (Lights) =>
        {
            Random r = new Random();
            System.Drawing.Color c = System.Drawing.Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            foreach (MLight l in Lights)
            {
                c = System.Drawing.Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                l.Theme.blendMode = BlendMode.None;
                l.Set(Layer.Theme, new FullColor(c, 255), 10);
            }
        });

        public static Scene VacationLights = new Scene("vacation_lights", 60, (Lights) =>
        {
            Random r = new Random();
            foreach (MLight l in Lights)
            {
                l.Theme.blendMode = BlendMode.Multiply;

                l.Set(Layer.Theme, new FullColor(255, 255, 255, (byte)r.Next(255), 255), 1);
            }
        });
    }
}