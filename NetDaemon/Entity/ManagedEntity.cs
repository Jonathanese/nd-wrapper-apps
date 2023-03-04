using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.HassModel.Entities;
using HomeAssistantGenerated;
using Microsoft.AspNetCore.Http.HttpResults;
using NetDaemonWrapper.Lighting;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NetDaemonWrapper;
using GeoCoordinatePortable;

namespace NetDaemonWrapper
{
    public class ManagedEntity
    {
        public static readonly string prefix = "invalid";

        /// <summary>
        /// Default implementation of list builder. Returning -1 indicates entity type has no builder.
        /// </summary>
        /// <returns></returns>
        public static int BuildList(IHaContext ha)
        { return -1; }

        public static List<Type> Types = new List<Type>();

        protected static SettingsFile settings;

        public readonly bool ControlEnabled;
        public readonly bool IsGroupEntity;
        public readonly bool LocationEnabled;
        public readonly EntityCoords Location;
        public readonly Area? Room = null;

        internal readonly Entity _entity;

        public Entity entity
        { get { return _entity; } }

        public static List<ManagedEntity> AllManagedEntities = new List<ManagedEntity>();

        public ManagedEntity(IHaContext _ha, Entity entity,
            bool _locationenabled = false,
            bool _isgroupentity = false,
            bool _controlenabled = false)
        {
            _entity = entity;
            settings = new SettingsFile(PATHS.ENTITIES + entity.EntityId + ".xml");
            Room = _ha.GetAreaFromEntityId(_entity.EntityId);

            LocationEnabled = bool.Parse(settings.ReadSetDefault("Location", "LocationEnabled", _locationenabled.ToString()));

            Location = read_coords_from_file();

            ControlEnabled = bool.Parse(settings.ReadSetDefault("General", "ControlEnabled", _controlenabled.ToString()));
            IsGroupEntity = bool.Parse(settings.ReadSetDefault("General", "IsGroupEntity", _isgroupentity.ToString()));
        }

        public static ManagedEntity? byName(string name)
        {
            return AllManagedEntities.FirstOrDefault(e => e.entity.EntityId == name);
        }

        private EntityCoords read_coords_from_file()
        {
            return new EntityCoords(
                    int.Parse(settings.ReadSetDefault("Location", "North", "0")),
                    int.Parse(settings.ReadSetDefault("Location", "West", "0")),
                    int.Parse(settings.ReadSetDefault("Location", "Height", "0")));
        }
    }

    [NetDaemonApp]
    internal class ManagedEntityListBuilder
    {
        public ManagedEntityListBuilder(IHaContext _ha, ILogger<ManagedEntityListBuilder> _logger)
        {
            EntityCoords.LoadGPSReference();

            //Get list of subtypes from System Reflection
            ManagedEntity.Types = typeof(ManagedEntity).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(ManagedEntity)) && !t.IsAbstract).ToList();

            String BuilderMessage = "Managed Types: ";
            foreach (var _type in ManagedEntity.Types)
            {
                BuilderMessage += _type.Name + " ";
            }
            _logger.Log(LogLevel.Information, BuilderMessage);

            foreach (var _type in ManagedEntity.Types)
            {
                var BuilderInfo = _type.GetMethod("BuildList");
                if (BuilderInfo != null)
                {
                    object[] _params = new object[] { _ha };
                    int? _count = (int?)BuilderInfo.Invoke(null, _params);
                    if (_count != null)
                    {
                        if (_count > -1)
                        {
                            _logger.Log(LogLevel.Information, _type.Name + "s: " + _count.ToString());
                        }
                        else
                        {
                            _logger.Log(LogLevel.Information, _type.Name + ": No List Builder Implemented");
                        }
                    }
                }
            }
        }
    }

    public class EntityCoords
    {
        public int N;
        public int W;
        public int H;
        private static int N_Max;
        private static int W_Max;
        private static int H_Max;
        private static GeoCoordinate GPS_Origin = new GeoCoordinate();

        public double N_rel
        { get { return (double)N / N_Max; } }

        public double W_rel
        { get { return (double)W / W_Max; } }

        public double H_rel
        { get { return (double)H / H_Max; } }

        public static void LoadGPSReference()
        {
            SettingsFile locationsettings = new SettingsFile(PATHS.LOCATION + "LocationSettings.xml");
            double lat = double.Parse(locationsettings.ReadSetDefault("General", "GPS_N", "0.00"));
            double lon = double.Parse(locationsettings.ReadSetDefault("General", "GPS_E", "0.00"));
            GPS_Origin.Latitude = lat;
            GPS_Origin.Longitude = lon;
        }

        public static EntityCoords GPStoLocal(GeoCoordinate GPS)
        {
            double lat = GPS_Origin.GetDistanceTo(new GeoCoordinate(GPS.Latitude, GPS_Origin.Longitude));
            double lon = GPS.GetDistanceTo(new GeoCoordinate(GPS.Latitude, GPS_Origin.Longitude)); //Inverted here because we use W coordinates

            lat *= 39.37007874; //Inches per Meter
            lon *= 39.37007874;

            return new EntityCoords((int)lat, (int)lon, 0);
        }

        /// <summary>
        /// Outputs distance between two coordinates.
        /// Currently in Inches
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int distance(EntityCoords a, EntityCoords b)
        {
            int N = b.N - a.N;
            int W = b.W - a.W;
            N = N * N;
            W = W * W;
            return (int)Math.Sqrt(N + W);
        }

        public EntityCoords(int North_Inches, int West_Inches, int Height_Inches)
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