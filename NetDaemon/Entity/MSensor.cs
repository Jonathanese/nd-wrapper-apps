using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantGenerated;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetDaemon.HassModel.Entities;
using NetDaemonWrapper;
using NetDaemonWrapper.Lighting;

namespace NetDaemonWrapper
{
    internal class MSensor : ManagedEntity
    {
        public new static readonly string prefix = "sensor.";
        public static List<MSensor> All = new List<MSensor>();
        public readonly SensorType sensorType;

        public new SensorEntity entity
        { get { return _entity as SensorEntity; } }

        public MSensor(IHaContext _ha, Entity _entity) : base(_ha, _entity, false, false, false)
        {
            sensorType = GetSensorType();

            All.Add(this);
        }

        public new static int BuildList(IHaContext ha)
        {
            All.Clear();
            var entitylist = ha.GetAllEntities();
            foreach (Entity _entity in entitylist)
            {
                if (_entity.EntityId != null)
                {
                    if (_entity.EntityId.StartsWith(prefix))
                    {
                        new MSensor(ha, _entity);
                    }
                }
            }
            return All.Count;
        }

        private SensorType GetSensorType()
        {
            switch (settings.ReadSetDefault("Sensor", "Type", "None"))
            {
                case "Door":
                case "DOOR":
                    return SensorType.DOOR;

                case "Temperature":
                case "Temp":
                case "TEMP":
                    return SensorType.TEMP;

                case "Humidity":
                case "Humid":
                case "HUMID":
                    return SensorType.HUMID;

                default:
                    return SensorType.NONE;
            }
        }
    }

    internal enum SensorType
    { NONE, DOOR, TEMP, HUMID }
}