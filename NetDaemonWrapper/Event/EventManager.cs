using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;

namespace NetDaemonWrapper.Events
{
    [NetDaemonApp]
    public class EventManager
    {
        private static EventManager _instance;

        public static EventManager Instance
        { get { return _instance; } }

        public delegate void ServiceEventHandler(DataElement d);

        public ServiceEventHandler SceneSetEvent;

        public EventManager(IHaContext _ha)
        {
            _instance = this;
            _ha.Events.Where(e => e.EventType == "call_service").Subscribe(e => { CallServiceHandler(e); });
            SceneSetEvent += nop;
            int dsa = Scene.Scene.All.Count;
            var asd = Scene.Scenes.NightLight.SceneName;
            asd = Scene.Scenes.NormalLights.SceneName;
        }

        private void CallServiceHandler(Event sender)
        {
            var d = toDataElement(sender.DataElement);

            if (d?.domain == null) return;
            switch (d.domain)
            {
                case "scene":
                    SceneSetEvent.Invoke(d);
                    break;
            }
        }

        private void nop(DataElement d)
        {
        }

        public static DataElement? toDataElement(JsonElement? j)
        {
            if (j == null) return null;
            try
            {
                return JsonConvert.DeserializeObject<DataElement>(j.ToString());
            }
            catch
            {
                return null;
            }
        }

        public static ServiceData? toServiceData(object? j)
        {
            if (j == null) return null;
            try
            {
                return JsonConvert.DeserializeObject<ServiceData>(j.ToString());
            }
            catch
            {
                return null;
            }
        }
    }

    public record DataElement
    {
        [JsonPropertyName("domain")]
        public string? domain { get; init; }
        [JsonPropertyName("service")]
        public string? service { get; init; }
        [JsonPropertyName("service_data")]
        public object? service_data { get; init; }
    }

    public record ServiceData
    {
        [JsonPropertyName("entity_id")]
        public string? entity_id { get; init; }
    }
}