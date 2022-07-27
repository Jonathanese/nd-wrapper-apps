using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemonWrapper.Lighting;

namespace NetDaemonWrapper.Event
{
    public static partial class StateChangeActions
    {
        public static StateChangeAction BackDoorOpen = new StateChangeAction("binary_sensor.homespy_9", true, () =>
        {
            MLight.byName("light.breakfast").Set(Layer.Anim, FullColor.Red, 1);
            MLight.byName("light.breakfast").UpdateNow();
        });

        public static StateChangeAction BackDoorClosed = new StateChangeAction("binary_sensor.homespy_9", false, () =>
        {
            MLight.byName("light.breakfast").Anim.isActive = false;
            MLight.byName("light.breakfast").UpdateNow();
        });

        public static StateChangeAction FrontDoorOpen = new StateChangeAction("binary_sensor.homespy_4", true, () =>
        {
            MLight.byName("light.entry").Set(Layer.Anim, FullColor.Red, 1);
            MLight.byName("light.entry").UpdateNow();
        });

        public static StateChangeAction FrontDoorClosed = new StateChangeAction("binary_sensor.homespy_4", false, () =>
        {
            MLight.byName("light.entry").Anim.isActive = false;
            MLight.byName("light.entry").UpdateNow();
        });
    }
}