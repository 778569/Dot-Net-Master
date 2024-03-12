using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class AnimalClass 
    {
        public void Speak()
        {
            Console.WriteLine("The animal speak");


        }
    }

    public class Dos() : IAnimal
    {
        //public void Speak()
        //{
        //    Console.WriteLine("Dos Bark");
        //}
        public void Speak()
        {
               Console.WriteLine("Cat Meows");

        }
    }

    public class Cat() : IAnimal
    {
        //public void Speak()
        //{
        //    Console.WriteLine("Dos Bark");
        //}
        public void Speak()
        {
            Console.WriteLine("Cat Meows");

        }
    }


    public interface IAnimal
    {
        void Speak();
    }
}
