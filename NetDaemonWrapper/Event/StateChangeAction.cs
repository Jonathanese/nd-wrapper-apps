using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemon;
using NetDaemon.Extensions;
using NetDaemon.HassModel.Entities;
using System.Reactive;
using System.Runtime.CompilerServices;

namespace NetDaemonWrapper.Event
{
    public class StateChangeAction
    {
        public delegate void Action();

        public StateChangeAction(string entityid, string newstate, Action action)
        {
            Context.ha.Entity(entityid).StateChanges().Where(e => e.New?.State == newstate).Subscribe(s => action());
        }

        public StateChangeAction(string entityid, string oldstate, string newstate, Action action)
        {
            Context.ha.Entity(entityid).StateChanges().Where(e => e.Old?.State == oldstate && e.New?.State == newstate).Subscribe(s => action());
        }

        public StateChangeAction(string entityid, bool LowToHigh, Action action)
        {
            if (LowToHigh)
                Context.ha.Entity(entityid).StateChanges().Where(e => e.New?.State == "on").Subscribe(s => action());
            else
                Context.ha.Entity(entityid).StateChanges().Where(e => e.New?.State == "off").Subscribe(s => action());
        }
    }
}