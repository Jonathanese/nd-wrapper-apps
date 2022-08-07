using NetDaemonWrapper.Lighting;
using System.Drawing;

namespace NetDaemonWrapper.Scene
{
    [NetDaemonApp]
    public partial class BasicScenes
    {
        public BasicScenes(IHaContext _ha, ILogger<BasicScenes> _logger)
        {
            Scene NightLight = new Scene(_ha, _logger,
                "night_light",
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
                    System.Drawing.Color c = System.Drawing.Color.FromArgb(Utils.PRNG(255), Utils.PRNG(255), Utils.PRNG(255));
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;
                        c = System.Drawing.Color.FromArgb(Utils.PRNG(255), Utils.PRNG(255), Utils.PRNG(255));
                        l.Theme.blendMode = BlendMode.None;
                        l.Set(Layer.Theme, new FullColor(c, 255), 15);
                    }
                });

            Scene VacationLights = new Scene(_ha, _logger,
                "vacation_lights",
                60,
                (Settings, Lights) =>
                {
                    int LightCountPercent = int.Parse(Settings.ReadSetDefault("Scene", "LightCountPercent", "25"));
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;
                        l.Theme.blendMode = BlendMode.Multiply;
                        if (Utils.PRNG(100) < LightCountPercent)
                        {
                            l.Set(Layer.Theme, new FullColor(255, 255, 255, 255, 255), 1);
                        }
                        else
                        {
                            l.Set(Layer.Theme, new FullColor(255, 255, 255, 0, 255), 1);
                        }
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

            Scene Flicker = new Scene(_ha, _logger,
                "flicker",
                0.5f,
                (Settings, Lights) =>
                {
                    int FlickerAmount = int.Parse(Settings.ReadSetDefault("Scene", "FlickerAmount", "25"));
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = true;
                        l.Theme.blendMode = BlendMode.Multiply;
                        if (Utils.PRNG(100) < FlickerAmount)
                        {
                            l.Set(Layer.Theme, new FullColor(255, 255, 255, 128, 255), 0.25f);
                        }
                        else
                        {
                            l.Set(Layer.Theme, FullColor.White, 0.25f);
                        }
                    }
                });
        }
    }
}