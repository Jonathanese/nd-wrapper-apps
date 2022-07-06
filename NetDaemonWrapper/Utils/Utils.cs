using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}