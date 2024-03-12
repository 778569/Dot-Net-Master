using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public static class StaticClass
    {
        public static int MyProperty { get; set; }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
