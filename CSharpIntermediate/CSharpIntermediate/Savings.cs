using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    class Savings : Account
    {
        public Savings() : base()
        {

        }
        public override bool Deposit(double Amount)
        {
            balance += Amount;
            Console.WriteLine($"Your Account balance is {balance}");
            return true;
        }

        public override bool Withdrawn(double Amount)
        {
            balance -= Amount;
            Console.WriteLine($"Your Account balance is {balance}");
            return true;
        }
    }
}
