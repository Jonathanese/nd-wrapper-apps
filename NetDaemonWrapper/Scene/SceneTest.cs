using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper.Lighting;
using NetDaemon.Extensions.Scheduler;
using System.Drawing;

namespace NetDaemonWrapper.Scene
{
    [NetDaemonApp]
    internal class SceneTest
    {
        public SceneTest(IHaContext _ha, INetDaemonScheduler _scheduler)
        {
            bool sw = true;
            Random rand = new Random();
            FullColor color = new FullColor(Color.FromArgb(128, 255, 0, 0), 255);
            FullColor color2 = new FullColor(Color.FromArgb(128, 0, 255, 0), 255);
            _scheduler.RunEvery(TimeSpan.FromSeconds(60), () =>
            {
                Console.WriteLine("Color");
                foreach (MLight light in LightManager.mLights)
                {
                    light.Theme.isActive = false;
                    light.Custom.isActive = false;
                    light.Theme.blendMode = BlendMode.Alpha;
                    light.Set(Layer.Theme, sw ? color : color2);
                }
                sw = !sw;
            });

            _scheduler.RunEvery(TimeSpan.FromSeconds(15), () =>
            {
                Console.WriteLine("Brightness");
                foreach (MLight light in LightManager.mLights)
                {
                    light.Anim.blendMode = BlendMode.Multiply;
                    FullColor mult = new FullColor(Color.White, (byte)rand.Next(0, 255));
                    light.Set(Layer.Anim, mult);
                }
            });
        }
    }
}