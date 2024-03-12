using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public delegate void MyDelegate(string message);
    public  static class MyClass
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }


    }

}
