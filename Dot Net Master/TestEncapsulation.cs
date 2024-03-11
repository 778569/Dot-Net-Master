using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class TestEncapsulation
    {

        private double _balance;  // private field representimng the internal state

        public double Balance
        {
            get { return _balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

    public void Withdraw(double amount)
        {
            if (amount > 0 && _balance>=amount)
            {
                _balance -= amount;
            }
        }
    }
}
