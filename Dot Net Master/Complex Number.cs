using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class Complex_Number
    {
        public double Real { get; set; }

        public double Imaginary { get; set; }

        public Complex_Number(double real, double imaginary)
        {
                this.Real = real;
                this.Imaginary = imaginary;
        }

        public static Complex_Number operator + (Complex_Number a, Complex_Number b)
        {
            return new Complex_Number(a.Real + b.Real, a.Imaginary + b.Imaginary);

        }
    }
}
