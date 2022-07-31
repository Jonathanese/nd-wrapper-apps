using NetDaemonWrapper.Lighting;

namespace NetDaemonWrapper.Event
{
    [NetDaemonApp]
    public partial class StateChangeActions
    {
        public StateChangeActions(IHaContext _ha)
        {
            var BackDoorOpen = new StateChangeAction(
                "binary_sensor.homespy_9",
                true,
                () =>
                {
                    MLight.byName("light.breakfast").Set(Layer.Anim, FullColor.Red, 1);
                    MLight.byName("light.breakfast").UpdateNow();
                });

            var BackDoorClosed = new StateChangeAction("binary_sensor.homespy_9", false, () =>
            {
                MLight.byName("light.breakfast").Anim.isActive = false;
                MLight.byName("light.breakfast").UpdateNow();
            });

            var FrontDoorOpen = new StateChangeAction("binary_sensor.homespy_4", true, () =>
            {
                MLight.byName("light.entry").Set(Layer.Anim, FullColor.Red, 1);
                MLight.byName("light.entry").UpdateNow();
            });

            var FrontDoorClosed = new StateChangeAction("binary_sensor.homespy_4", false, () =>
            {
                MLight.byName("light.entry").Anim.isActive = false;
                MLight.byName("light.entry").UpdateNow();
            });
        }
    }
}