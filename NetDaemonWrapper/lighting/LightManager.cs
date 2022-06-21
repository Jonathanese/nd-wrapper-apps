using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace NDManagers
{
    internal static class LightManager
    {
        public static List<MLight> mLights = new List<MLight>();
        public static readonly IHaContext ha;

        public static void BuildList(IHaContext ha)
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
    }
}