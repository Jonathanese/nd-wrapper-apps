using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper;
using NetDaemon.HassModel.Entities;

namespace NetDaemonWrapper
{
    internal class PositionedSensor : PositionedEntity
    {
        public PositionedSensor(IHaContext ha, Entity e) : base(ha, e)
        {
        }
    }
}