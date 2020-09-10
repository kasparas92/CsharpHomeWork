using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    class Current : Account
    {
        public double minBalance = 100000;
        private double dailyWithdraw = 20000;

        public Current() : base()
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
            if(Amount > balance)
            {
                Console.WriteLine("Your Account insufficient balance");
                return false;
            }
            else if(Amount > dailyWithdraw)
            {
                Console.WriteLine($"You cannot withdraw more than {dailyWithdraw}");
                return false;
            }
            else
            {
                balance -= Amount;
                Console.WriteLine($"Your Account balance is {balance}");
                return true;
            }
        }
    }
}
