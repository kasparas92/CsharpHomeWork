using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpIntermediate
{
    class Bank
    {
        public string[] custName = new string[3];
        public string[] custId = new string[3];
        public string[] accTypes = new string[3];
        public string[] myDOB = new string[3];
        public double[] myBalance = new double[3];
        public string id;//hold id generated from IdGenerator class and add string;
        public int idnum = 0;//index number for Account Id;
        public double depositAmount;
        private string prefix;

        public bool val = true;
        public bool depositVal = true;

        IdGenerator id1 = new IdGenerator();
        DateOfBirth dob = new DateOfBirth();
        Savings sa = new Savings();
        Current curr = new Current();

        public void CreateAccount()
        {
            int d, y, m;
            string name, accType;
            double balance;
            Console.WriteLine("1. Savings");
            Console.WriteLine("2. Current");
            var input = Console.ReadLine();
            if(input == "1")
            {
                accType = "Savings";
                accTypes[idnum] = accType;
            }
            else
            {
                accType = "Current";
                accTypes[idnum] = accType;
            }
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            custName[idnum] = name;
            while (val)
            {
                Console.WriteLine("Enter date of Birth: ");
                d = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                dob.AssignValue(d, m, y);
                if (dob.DisplayDate())
                {
                    myDOB[idnum] = Convert.ToString($"{d} {m} {y}");
                    val = false;
                }
                else
                {
                    val = true;
                }

            }
            val = true;
            
            if (accType == "Savings")
            {
                Console.WriteLine("Enter the Balance: ");
                balance = Convert.ToDouble(Console.ReadLine());
                myBalance[idnum] = balance;
            }
            else
            {
                while (depositVal)
                {
                    Console.WriteLine("Enter the Balance: ");
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance < curr.minBalance)
                    {
                        Console.WriteLine($"Your specified balance is not sufficient. It should be atleast {curr.minBalance}");
                        depositVal = true;
                    }
                    else
                    {
                        myBalance[idnum] = balance;
                        depositVal = false;
                    }
                }
                depositVal = true;
            }
            prefix = (accType == "Savings") ? "EMI" : "Current";
            Console.WriteLine($"{accType} Account created successfully");
            id = prefix + id1.GenerateId();
            custId[idnum] = id;
            Console.WriteLine($"Your Account Number is {id}");
            idnum++;
        }

        public void ShowAccountDetails()
        {
            var accountId = Console.ReadLine();
            if(custId.Contains(accountId))
            {
                Console.WriteLine($"Name: {custName[Array.IndexOf(custId, id)]}");
                Console.WriteLine($"Id: {custId[Array.IndexOf(custId, id)]}");
                Console.WriteLine($"Acc Type: {accTypes[Array.IndexOf(custId, id)]}");
                Console.WriteLine($"Balance: {myBalance[Array.IndexOf(custId, id)]}");
                Console.WriteLine($"DOB: {myDOB[Array.IndexOf(custId, id)]}");
            }
            else
            {
                Console.WriteLine("You passed wrong Id");
            }
        }

        public void Deposit()
        {
            int indexNum;
            var inId = Console.ReadLine();
            if(custId.Contains(inId))
            {
                indexNum = Array.IndexOf(custId, inId);
                Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                Console.WriteLine("Enter the amount you want to deposit: ");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                if(accTypes[indexNum] == "Savings")
                {
                    sa.balance = myBalance[indexNum];
                    sa.Deposit(depositAmount);
                    myBalance[indexNum] = sa.balance;
                }
                else if(accTypes[indexNum] == "Current")
                {
                    curr.balance = myBalance[indexNum];
                    curr.Deposit(depositAmount);
                    myBalance[indexNum] = curr.balance;
                }
                else
                {
                    Console.WriteLine("Enter Correct Account Id");
                }
            }
        }

        public void Withdrawn()
        {
            int indexNum;
            var inId = Console.ReadLine();
            if (custId.Contains(inId))
            {
                indexNum = Array.IndexOf(custId, inId);
                Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                Console.WriteLine("Enter the amount you want to withdrawn: ");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                if (accTypes[indexNum] == "Savings")
                {
                    sa.balance = myBalance[indexNum];
                    sa.Withdrawn(depositAmount);
                    myBalance[indexNum] = sa.balance;
                }
                else if (accTypes[indexNum] == "Current")
                {
                    curr.balance = myBalance[indexNum];
                    curr.Withdrawn(depositAmount);
                    myBalance[indexNum] = curr.balance;
                }
                else
                {
                    Console.WriteLine("Enter Correct Account Id");
                }
            }
        }
    }
}
