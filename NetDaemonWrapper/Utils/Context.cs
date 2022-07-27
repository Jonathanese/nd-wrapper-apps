using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonWrapper
{
    [NetDaemonApp]
    public class Context
    {
        public static IHaContext ha;

        public Context(IHaContext _ha)
        {
            ha = _ha;
        }
    }
}