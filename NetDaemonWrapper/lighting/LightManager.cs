using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;
using System.Drawing;

namespace NetDaemonWrapper.Lighting
{
    [NetDaemonApp]
    internal class LightManager
    {
        public static List<MLight> mLights = new List<MLight>();
        private Timer CircadianTimer;
        private Timer LightUpdateTimer;
        private LightManagerConfig LightManConfig;
        private readonly ILogger Logger;

        public LightManager(IHaContext _ha, ILogger<LightManager> _logger, IAppConfig<LightManagerConfig> _config)
        {
            Logger = _logger;
            LightManConfig = _config.Value;
            Logger.LogInformation("Build Light List");
            BuildList(_ha);
            InitTimers();
        }

        private void InitTimers()
        {
            LightUpdateTimer = new Timer(UpdateLights);
            //LightUpdateTimer.Change(0, LightManConfig.LightUpdateSeconds * 1000);
            LightUpdateTimer.Change(0, 1000);

            CircadianTimer = new Timer(CircadianSet);
            //CircadianTimer.Change(0, LightManConfig.CircadianUpdateSeconds * 1000);
            CircadianTimer.Change(0, 60000);
        }

        private void BuildList(IHaContext ha)
        {
            mLights.Clear();
            var entitylist = ha.GetAllEntities();
            foreach (Entity _entity in entitylist)
            {
                if (_entity.EntityId != null)
                {
                    if (_entity.EntityId.StartsWith("light."))
                    {
                        if (!_entity.EntityId.StartsWith("light.theme."))
                        {
                            LightEntity newlight = new LightEntity(_entity);
                            mLights.Add(new MLight(newlight));
                        }
                    }
                }
            }
        }

        private void UpdateLights(object? sender)
        {
            //Light blending and conversion running in parallel
#if true
            Parallel.ForEach(mLights, currentLight =>
            {
                currentLight.ProcessState();
            });
#else
            foreach (MLight currentLight in mLights)
            {
                currentLight.ProcessState();
            }
#endif

            //Actual display handled in series to reduce potential unsafe conflicts.
            //TODO: See if light states can be aggregated and updated in a single command.
            foreach (MLight currentLight in mLights)
            {
                currentLight.Show();
            }
        }

        private void CircadianSet(object? sender)
        {
            foreach (MLight light in mLights)
            {
                light.Set(Layer.Base, new FullColor(Color.Blue, 255));
            }
        }
    }

    public class LightManagerConfig
    {
        public int CircadianUpdateSeconds { get; set; } = 60;
        public int LightUpdateSeconds { get; set; } = 10;
    }
}