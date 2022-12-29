using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using System.Drawing;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using NetDaemonWrapper;

namespace NetDaemonWrapper.Lighting
{
    [NetDaemonApp]
    internal class LightManager
    {
        private Timer CircadianTimer;
        private Timer LightUpdateTimer;
        private readonly ILogger Logger;
        private readonly IHaContext ha;
        private SettingsFile LocalSettings;
        public int CircadianUpdateMilliseconds;
        public int LightUpdateMilliseconds;

        public static DateTime Sunrise;
        public static DateTime Sunset;
        public static float Now_Minute;
        public static float Sunset_Minute;
        public static float Sunrise_Minute;

        public string CircadianEntityName;
        public string SunEntityName;

        public LightManager(IHaContext _ha, ILogger<LightManager> _logger)
        {
            InitSettings();
            ha = _ha;
            Logger = _logger;
            Logger.LogInformation("Build Light List");
            BuildList();
            InitTimers();
        }

        private void InitSettings()
        {
            LocalSettings = new SettingsFile(PATHS.LIGHTING + "LightManager.xml");
            CircadianEntityName = LocalSettings.ReadSetDefault("General", "CircadianEntity", "sensor.circadian_values");
            SunEntityName = LocalSettings.ReadSetDefault("General", "SunEntity", "sun.sun");
            LightUpdateMilliseconds = (int)(1000 * float.Parse(LocalSettings.ReadSetDefault("Timers", "LightUpdateSeconds", "0.25")));
            CircadianUpdateMilliseconds = (int)(1000 * float.Parse(LocalSettings.ReadSetDefault("Timers", "CircadianUpdateSeconds", "60.0")));
        }

        private void InitTimers()
        {
            LightUpdateTimer = new Timer(UpdateLights);
            LightUpdateTimer.Change(0, LightUpdateMilliseconds);

            CircadianTimer = new Timer(CircadianSet);
            CircadianTimer.Change(0, CircadianUpdateMilliseconds);
        }

        private void BuildList()
        {
            MLight.All.Clear();
            var entitylist = ha.GetAllEntities();
            foreach (Entity _entity in entitylist)
            {
                if (_entity.EntityId != null)
                {
                    if (_entity.EntityId.StartsWith("light."))
                    {
                        if (!_entity.EntityId.StartsWith("light.theme."))
                        {
                            new MLight(ha, new LightEntity(_entity));
                        }
                    }
                }
            }
        }

        private void UpdateLights(object? sender)
        {
            //Light blending and conversion running in parallel
            Parallel.ForEach(MLight.All, currentLight =>
            {
                currentLight.ProcessState();
            });

            //Actual display handled in series to reduce potential unsafe conflicts.
            //TODO: See if light states can be aggregated and updated in a single command.
            foreach (MLight currentLight in MLight.All)
            {
                currentLight.Show();
            }
        }

        private void CircadianSet(object? sender)
        {
            UpdateSunriseSunset();

            FullColor kColor = new FullColor(getCircadianColor(), 255);
            foreach (MLight light in MLight.All)
            {
                light.Set(Layer.Base, kColor, 3);
            }
        }

        private void UpdateSunriseSunset()
        {
            var sunattr = ha.Entity(SunEntityName).WithAttributesAs<SunAttributes>();
            if (sunattr != null)
            {
                if (sunattr.Attributes != null)
                {
                    if (sunattr.Attributes.NextRising != null && sunattr.Attributes.NextSetting != null)
                    {
                        Sunrise = DateTime.Parse(sunattr.Attributes.NextRising);
                        Sunset = DateTime.Parse(sunattr.Attributes.NextSetting);

                        Sunset_Minute = Sunset.Minute + (60 * Sunset.Hour);
                        Sunrise_Minute = Sunrise.Minute + (60 * Sunrise.Hour);
                        Now_Minute = DateTime.Now.Minute + (60 * DateTime.Now.Hour);

                        Logger.LogInformation("Sunrise: " + Sunrise_Minute);
                        Logger.LogInformation("Sunset: " + Sunset_Minute);
                        Logger.LogInformation("Now: " + Now_Minute);


                    }
                }
            }
        }

        private Color getCircadianColor()
        {
            Color kColor = Color.White;
            var attr = ha.Entity(CircadianEntityName).WithAttributesAs<CircadianAttributes>().Attributes;
            var cValues = attr.rgb_color;
            if (cValues != null)
            {
                if (cValues.Length == 3)
                {
                    kColor = Color.FromArgb(255, (int)cValues[0], (int)cValues[1], (int)cValues[2]);
                }
            }
            return kColor;
        }

        private record CircadianAttributes
        {
            [JsonPropertyName("colortemp")]
            public double? colortemp { get; init; }

            [JsonPropertyName("rgb_color")]
            public double[]? rgb_color { get; init; }
        }
    }
}