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
    internal class EventManager
    {
        public delegate void ServiceEventHandler(DataElement d);

        public ServiceEventHandler SceneSetEvent;

        public EventManager(IHaContext _ha)
        {
            _ha.Events.Where(e => e.EventType == "call_service").Subscribe(e => { CallServiceHandler(e); });

            SceneSetEvent += PostEvent;
        }

        private void CallServiceHandler(Event sender)
        {
            string domain = toDataElement(sender.DataElement).domain;

            if (domain == null) return;
            switch (domain)
            {
                case "scene":
                    SceneSetEvent.Invoke(toDataElement(sender.DataElement));
                    break;
            }
        }

        private void PostEvent(DataElement d)
        {
            ServiceData? sd = toServiceData(d.service_data);
            Console.WriteLine("Scene Set: " + sd?.entity_id);
        }

        public static DataElement? toDataElement(JsonElement? j)
        {
            return JsonConvert.DeserializeObject<DataElement>(j.ToString());
        }

        public static ServiceData? toServiceData(object? j)
        {
            return JsonConvert.DeserializeObject<ServiceData>(j.ToString());
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