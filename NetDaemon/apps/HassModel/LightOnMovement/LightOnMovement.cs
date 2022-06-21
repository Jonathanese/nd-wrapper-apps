// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace HassModel;

/// <summary>
///     Showcase using the new HassModel API and turn on light on movement
/// </summary>
[NetDaemonApp]
public class LightOnMovement
{
    public LightOnMovement(IHaContext ha)
    {
        ha.Entity("binary_sensor.livingroom_pir")
            .StateChanges().Where(e => e.New?.State == "on")
            .Subscribe(_ => ha.Entity("light.livingroom").CallService("turn_on"));
    }
}
