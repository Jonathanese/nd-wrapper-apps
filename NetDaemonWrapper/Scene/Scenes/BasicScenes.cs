using NetDaemonWrapper.Lighting;

namespace NetDaemonWrapper.Scene
{
    [NetDaemonApp]
    public partial class BasicScenes
    {
        public BasicScenes(IHaContext _ha, ILogger<BasicScenes> _logger)
        {
            Scene NightLight = new Scene(_ha, _logger,
                "night_light",
                (Lights) =>
                {
                    foreach (MLight l in Lights)
                    {
                        l.Theme.blendMode = BlendMode.Alpha;
                        l.Set(Layer.Theme, FullColor.Black, 5);
                    }
                });

            Scene NormalLights = new Scene(_ha, _logger,
                "normal_lights",
                (Lights) =>
                {
                    foreach (MLight l in Lights)
                    {
                        l.Theme.isActive = false;
                    }
                });

            Scene RandomColors = new Scene(_ha, _logger,
                "random_colors",
                10,
                (Lights) =>
                {
                    Random r = new Random();
                    System.Drawing.Color c = System.Drawing.Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    foreach (MLight l in Lights)
                    {
                        c = System.Drawing.Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                        l.Theme.blendMode = BlendMode.None;
                        l.Set(Layer.Theme, new FullColor(c, 255), 15);
                    }
                });

            Scene VacationLights = new Scene(_ha, _logger,
                "vacation_lights",
                60,
                (Lights) =>
                {
                    Random r = new Random();
                    foreach (MLight l in Lights)
                    {
                        l.Theme.blendMode = BlendMode.Multiply;
                        if (r.Next(100) < 25)
                        {
                            l.Set(Layer.Theme, new FullColor(255, 255, 255, 255, 255), 1);
                        }
                        else
                        {
                            l.Set(Layer.Theme, new FullColor(255, 255, 255, 0, 255), 1);
                        }
                    }
                });
        }
    }
}