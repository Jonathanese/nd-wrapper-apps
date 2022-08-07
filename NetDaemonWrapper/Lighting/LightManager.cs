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

        public string CircadianEntityName;

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
            LocalSettings = new SettingsFile("/Lighting/LightManager.xml");
            CircadianEntityName = LocalSettings.ReadSetDefault("General", "CircadianEntity", "sensor.circadian_values");
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
#if true
            Parallel.ForEach(MLight.All, currentLight =>
            {
                currentLight.ProcessState();
            });
#else
            foreach (MLight currentLight in MLight.All)
            {
                currentLight.ProcessState();
            }
#endif

            //Actual display handled in series to reduce potential unsafe conflicts.
            //TODO: See if light states can be aggregated and updated in a single command.
            foreach (MLight currentLight in MLight.All)
            {
                currentLight.Show();
            }
        }

        private void CircadianSet(object? sender)
        {
            FullColor kColor = new FullColor(getCircadianColor(), 255);
            foreach (MLight light in MLight.All)
            {
                light.Set(Layer.Base, kColor, 3);
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