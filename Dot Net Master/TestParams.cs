using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class TestParams
    {
        public static int Sum(params int[] values)
        {
            int sum = 0;
            foreach (int value in values) 
            { 
                sum += value;
            }
            return sum;
        }
    }
}
