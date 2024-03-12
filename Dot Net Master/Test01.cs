using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class Test01
    {
        private readonly IAnimal animal;

        public Test01(IAnimal animal)
        {
            this.animal = animal;
        }

       public void TestDog()
        {
            animal.Speak();
        }
    }
}
