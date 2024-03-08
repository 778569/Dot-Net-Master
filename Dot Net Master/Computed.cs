using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class Computed
    {

        public Computed(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            
        }
        private string? FirstName { get; set; }

        private string? LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FullName} {LastName}";
            }
        }
    }
}
