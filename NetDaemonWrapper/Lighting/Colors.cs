using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NetDaemonWrapper.Lighting
{
    public partial class FullColor
    {
        public static readonly FullColor Black = new FullColor(Color.Black, 0);
        public static readonly FullColor White = new FullColor(Color.White, 0);
        public static readonly FullColor Red = new FullColor(Color.Red, 0);
        public static readonly FullColor Green = new FullColor(Color.Green, 0);
        public static readonly FullColor Blue = new FullColor(Color.Blue, 0);
        public static readonly FullColor Cyan = new FullColor(Color.Cyan, 0);
        public static readonly FullColor Magenta = new FullColor(Color.Magenta, 0);
        public static readonly FullColor Yellow = new FullColor(Color.Yellow, 0);
    }
}