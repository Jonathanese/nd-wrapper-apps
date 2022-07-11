using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;

namespace NetDaemonWrapper
{
    public static class Utils
    {
        private static Random _random = new Random();

        public static bool RollPermil(int threshold)
        {
            return (_random.Next(0, 1000) < threshold);
        }

        public static bool RollPercent(int threshold)
        {
            return (_random.Next(0, 100) < threshold);
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