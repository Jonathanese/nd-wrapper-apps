using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.HassModel.Entities;
using HomeAssistantGenerated;

namespace NetDaemonWrapper
{
    public class ConfiguredEntity
    {
        protected static SettingsFile settings;
        public bool ControlEnabled = true;
        public bool LocationEnabled = true;
        public readonly coords Location;
        public readonly Area? Room = null;
        internal readonly Entity _entity;

        public ConfiguredEntity(IHaContext _ha, Entity entity)
        {
            _entity = entity;
            settings = new SettingsFile(PATHS.ENTITIES + entity.EntityId + ".xml");
            Room = _ha.GetAreaFromEntityId(_entity.EntityId);

            ControlEnabled = bool.Parse(settings.ReadSetDefault("General", "ControlEnabled", "true"));
            LocationEnabled = bool.Parse(settings.ReadSetDefault("Location", "LocationEnabled", "true"));
            Location = new coords(
                int.Parse(settings.ReadSetDefault("Location", "North", "0")),
                int.Parse(settings.ReadSetDefault("Location", "West", "0")),
                int.Parse(settings.ReadSetDefault("Location", "Height", "0")));
        }
    }

    public class coords
    {
        public int N;
        public int W;
        public int H;
        private static int N_Max;
        private static int W_Max;
        private static int H_Max;

        public double N_rel
        { get { return (double)N / N_Max; } }

        public double W_rel
        { get { return (double)W / W_Max; } }

        public double H_rel
        { get { return (double)H / H_Max; } }

        public coords(int North_Inches, int West_Inches, int Height_Inches)
        {
            N = North_Inches;
            W = West_Inches;
            H = Height_Inches;
            N_Max = Math.Max(N_Max, N);
            W_Max = Math.Max(W_Max, W);
            H_Max = Math.Max(H_Max, H);
        }
    }
}