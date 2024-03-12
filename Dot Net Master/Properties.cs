using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class Properties
    {
        public string? Name;

        public string name
        {
            get {
                return name; 
                }
            set {
                name = value; 
                }
        }

        public int Age { get; set; }

        public string? School { get; set; }
    }
}
