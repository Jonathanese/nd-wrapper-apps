using NetDaemonWrapper.Lighting;
using System.Drawing;

namespace NetDaemonWrapper.Scene
{
    [NetDaemonApp]
    public partial class BasicScenes
    {
        public BasicScenes(IHaContext _ha, ILogger<BasicScenes> _logger)
        {
            Scene NightLightDynamic = new Scene(_ha, _logger,
                "night_light_dynamic",
                (Settings, Lights) =>
                {
                    bool isHeightBased = bool.Parse(Settings.ReadSetDefault("Scene", "IsHeightBased", "true"));
                    byte maxbrightness = byte.Parse(Settings.ReadSetDefault("Scene", "MaxBrightness", "64"));
                    double maxheightrel = double.Parse(Settings.ReadSetDefault("Scene", "MaxHeightPct", "80")) / 100.0;
                    byte brightness = 0;

                    if (isHeightBased)
                    {
                        foreach (MLight l in Lights)
                        {
                            l.Theme.isActive = true;
                            l.Theme.blendMode = BlendMode.None;
                            brightness = (byte)((Math.Clamp(maxheightrel - l.Location.H_rel, 0, 1)) * maxbrightness);
                            l.Set(Layer.Theme, new FullColor(Color.Red, brightness), 5);
                        }
                    }
                    else
                    {
                        foreach (MLight l in Lights)
                        {
                            l.Theme.isActive = true;
                            l.Theme.blendMode = BlendMode.None;
                            l.Set(Layer.Theme, FullColor.Black, 5);
                        }
                    }
                });

            Scene NormalLights = new Scene(_ha, _logger,
                "normal_lights",
                (Settings, Lights) =>
                {
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = false;
                    }
                });

            Scene RandomColors = new Scene(_ha, _logger,
                "random_colors",
                10,
                (Settings, Lights) =>
                {
                    int updateseconds = int.Parse(Settings.GetValue("Settings", "UpdateSeconds"));
                    FullColor c = new FullColor((byte)Utils.PRNG(255), (byte)Utils.PRNG(255), (byte)Utils.PRNG(255), 255, 255);
                    c.Normalize();
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;
                        c = new FullColor((byte)Utils.PRNG(255), (byte)Utils.PRNG(255), (byte)Utils.PRNG(255), 255, 255);
                        c.Normalize();
                        l.Theme.blendMode = BlendMode.None;
                        l.Set(Layer.Theme, c, updateseconds);
                    }
                });

            Scene SpatialDemo = new Scene(_ha, _logger,
                "spatial_demo",
                10,
                (Settings, Lights) =>
                {
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;
                        FullColor color = new FullColor(0, 0, 0, 0, 255);
                        color.r16 = (int)(l.Location.N_rel * 65535);
                        color.g16 = (int)(l.Location.W_rel * 65535);
                        color.b16 = (int)(l.Location.H_rel * 65535);
                        l.Set(Layer.Theme, color, 1);
                    }
                });
            Scene SpatialGradientDemo = new Scene(_ha, _logger,
                "spatial_gradient_demo", 5, (Settings, Lights) =>
                {
                    Gradient? g = Gradient.getGradientFromName(Settings.ReadSetDefault("Scene", "Gradient", "Test"));

                    if (g == null) return;

                    int updateseconds = int.Parse(Settings.GetValue("Settings", "UpdateSeconds"));

                    float time = (float)(DateTime.Now.TimeOfDay.TotalSeconds % 300) / 300;

                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;

                        FullColor color = new FullColor(g.GetColor((float)l.Location.W_rel, time), 255);
                        l.Set(Layer.Theme, color, updateseconds);
                    }
                });
            Scene DuskDawn = new Scene(_ha, _logger,
                "duskdawn", 10, (Settings, Lights) =>
                {
                    float sunrise = float.Parse(Settings.ReadSetDefault("Scene", "Sunrise_kf", ".01"));
                    float sunset = float.Parse(Settings.ReadSetDefault("Scene", "Sunset_kf", ".99"));
                    int updateseconds = int.Parse(Settings.GetValue("Settings", "UpdateSeconds"));

                    float keytime = 0;

                    //Remap time so that sunrise and sunset align.
                    if (LightManager.Now_Minute < LightManager.Sunrise_Minute)
                    {
                        //Before sunrise
                        keytime = Utils.Map(LightManager.Now_Minute, 0, LightManager.Sunrise_Minute, 0, sunrise);
                    }
                    else if (LightManager.Now_Minute > LightManager.Sunset_Minute)
                    {
                        //After sunset
                        keytime = Utils.Map(LightManager.Now_Minute, LightManager.Sunset_Minute, 1440, sunset, 100);
                    }
                    else
                    {
                        //Daytime
                        keytime = Utils.Map(LightManager.Now_Minute, LightManager.Sunrise_Minute, LightManager.Sunset_Minute, sunrise, sunset);
                    }

                    Gradient? g = Gradient.getGradientFromName(Settings.ReadSetDefault("Scene", "Gradient", "DuskDawn"));
                    if (g == null) return;

                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;

                        FullColor color = new FullColor(g.GetColor((float)l.Location.W_rel, keytime), 255);
                        l.Set(Layer.Theme, color, updateseconds);
                    }
                });
        }
    }
}