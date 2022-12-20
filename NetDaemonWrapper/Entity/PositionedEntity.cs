using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.HassModel.Entities;
using HomeAssistantGenerated;

namespace NetDaemonWrapper
{
    public class PositionedEntity
    {
        private static SettingsFile settings = new SettingsFile(PATHS.LOCATION + "EntityLocations.xml");
        public bool LocationEnabled = true;
        public readonly coords Location;
        public readonly Area? Room = null;
        internal readonly Entity _entity;

        public PositionedEntity(IHaContext _ha, Entity entity)
        {
            _entity = entity;
            Room = _ha.GetAreaFromEntityId(_entity.EntityId);
            LocationEnabled = bool.Parse(settings.ReadSetDefault(_entity.EntityId, "Location_Enabled", "true"));
            Location = new coords(
                int.Parse(settings.ReadSetDefault(_entity.EntityId, "North_Inches", "0")),
                int.Parse(settings.ReadSetDefault(_entity.EntityId, "West_Inches", "0")),
                int.Parse(settings.ReadSetDefault(_entity.EntityId, "Height_Inches", "0")));
        }
    }

    public class coords
    {
        public int N_in;
        public int W_in;
        public int H_in;
        private static int N_Max;
        private static int W_Max;
        private static int H_Max;

        public double N_rel
        { get { return (double)N_in / N_Max; } }

        public double W_rel
        { get { return (double)W_in / W_Max; } }

        public double H_rel
        { get { return (double)H_in / H_Max; } }

        public coords(int North_Inches, int West_Inches, int Height_Inches)
        {
            N_in = North_Inches;
            W_in = West_Inches;
            H_in = Height_Inches;
            N_Max = Math.Max(N_Max, N_in);
            W_Max = Math.Max(W_Max, W_in);
            H_Max = Math.Max(H_Max, H_in);
        }
    }
}