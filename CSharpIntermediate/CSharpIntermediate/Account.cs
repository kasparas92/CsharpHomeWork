using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    abstract class Account
    {
        public string custName;
        public DateOfBirth DOB;
        public double balance;
        protected string accType;
        public double amount;

        public int MyProperty { get; set; }
        public abstract bool Deposit(double Amount);
        public abstract bool Withdrawn(double Amount);

        public Account(string name, DateOfBirth dateOfBirth, double balance)
        {
            custName = name;
            DOB = dateOfBirth;
            this.balance = balance;
        }

        protected Account()
        {

        }

        public string GetAccType()
        {
            accType = Console.ReadLine();
            return accType;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Customer Name {custName}");
            Console.WriteLine($"Customer DOB {DOB}");
            Console.WriteLine($"Balance {balance}");
        }
    }
}
