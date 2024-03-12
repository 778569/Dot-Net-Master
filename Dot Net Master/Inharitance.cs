using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class Inharitance
    {
    }

    public class Animal 
    {

        public int Legs { get; set; }

        public Animal(int legs)
        {
            this.Legs = legs;
            Console.WriteLine($"This animal has {legs}");
        }

       
    }
    public class Dog : Animal
    {
        public Dog(int legs) : base(legs)
        {
            Console.WriteLine("Your Dog has four leags");
        }
    }

}
