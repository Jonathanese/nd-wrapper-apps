using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.Extensions.Scheduler;
using HomeAssistantGenerated;
using NDWrapper;
using NDWrapper.Lighting;
using System.Drawing;

namespace TestApps
{
    [NetDaemonApp]
    internal class WrapperTestApp
    {
        public WrapperTestApp(IHaContext _ha, INetDaemonScheduler _scheduler, ILogger<WrapperTestApp> _logger)
        {
        }
    }
}