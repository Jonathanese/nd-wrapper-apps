using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.Extensions.Scheduler;
using HomeAssistantGenerated;
using NDExtensions;
using NDManagers;
using System.Drawing;

namespace TestApps
{
    [NetDaemonApp]
    internal class WrapperTestApp
    {
        public WrapperTestApp(IHaContext _ha, INetDaemonScheduler _scheduler, ILogger<WrapperTestApp> _logger)
        {
            _logger.LogInformation("Build List");
            LightManager.BuildList(_ha);

            foreach (MLight l in LightManager.mLights)
            {
                Console.WriteLine(l.entity.EntityId);
            }
            var r = new Random();
            var c = new Color();
            _scheduler.RunEvery(TimeSpan.FromSeconds(10), () =>
            {
                foreach (MLight l in LightManager.mLights)
                {
                    if (r.Next(100) > 90)
                    {
                        l.Set(Layer.Base, Color.White, 255);
                    }
                    else
                    {
                        l.Set(Layer.Base, Color.Black, 0);
                    }
                }
            });
        }
    }
}