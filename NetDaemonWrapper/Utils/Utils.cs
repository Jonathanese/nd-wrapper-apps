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
        private static uint seed = 0;

        private static Random _r = new Random();

        public static int PRNG(int maxvalue)
        {
            /*
            seed += 45693;
            seed *= 968500;
            seed ^= 772390;
            return Math.Abs((int)seed % maxvalue);
            */
            return _r.Next(maxvalue);
        }

        public static bool RollPermil(int threshold)
        {
            return (PRNG(1000) < threshold);
        }

        public static bool RollPercent(int threshold)
        {
            return (PRNG(100) < threshold);
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

        public static int Max(int a = int.MinValue, int b = int.MinValue, int c = int.MinValue, int d = int.MinValue, int e = int.MinValue, int f = int.MinValue)
        {
            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;
            if (a < f) a = f;
            return a;
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