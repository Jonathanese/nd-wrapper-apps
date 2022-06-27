using NetDaemon.AppModel;
using NetDaemon.HassModel;
using HomeAssistantGenerated;

namespace NetDaemonWrapper.Lighting
{
    public static class LightExtensions
    {
        public static void Set(this LightEntity _light, ColorBright _colorBright)
        {
            if (_colorBright.brightness == 0)
            {
                _light.TurnOff();
                return;
            }
            var color = new int[] { _colorBright.r, _colorBright.g, _colorBright.b };
            _light.TurnOn(rgbColor: color);
        }
    }
}
