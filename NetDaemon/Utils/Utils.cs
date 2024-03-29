﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NetDaemonWrapper
{
    internal static class PATHS
    {
        public const string CONFIG_BASE = "Config/";
        public const string LIGHTING = "Lighting/";
        public const string GRADIENTS = LIGHTING + "Gradients/";
        public const string SCENES = LIGHTING + "Scenes/";
        public const string LOCATION = "Location/";
        public const string ENTITIES = "Entities/";
    }

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

        public static int Max(int a = int.MinValue, int b = int.MinValue, int c = int.MinValue, int d = int.MinValue, int e = int.MinValue, int f = int.MinValue)
        {
            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;
            if (a < f) a = f;
            return a;
        }

        public static float lerp(float A, float B, float ratio)
        {
            return (A * (1 - ratio) + B * ratio);
        }

        public static float powerlerp(float A, float B, float ratio)
        {
            A *= A;
            B *= B;
            return (float)Math.Sqrt(lerp(A, B, ratio));
        }

        public static float getRatio(float A, float B, float ab)
        {
            //Cut everything before A for both such that A = 0;
            B = B - A;
            if (B == 0) return 0; //Prevent division by zero for overlapping points.
            ab = ab - A;
            //Scale everything such that B = 1.
            ab = ab / B;
            return ab;
        }

        public static float Map(float x, float xMin, float xMax, float yMin, float yMax)
        {
            return (x - xMin) * (yMax - yMin) / (xMax - xMin) + yMin;
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
}