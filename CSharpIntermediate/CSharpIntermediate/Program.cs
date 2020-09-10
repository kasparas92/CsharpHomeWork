using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            var bank = new Bank();
            Console.WriteLine("Welcomen to then banko Systemo Managemento");

            while(true)
            {
                Console.WriteLine("How we can help you?");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Show Account");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdrawn Amount");
                Console.WriteLine("5. Cleare screen");
                Console.WriteLine("6. Leave Banking App");

                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.WriteLine("Enter Account Type");
                        bank.CreateAccount();
                        break;
                    case "2":
                        Console.WriteLine("Enter AccountId");
                        bank.ShowAccountDetails();
                        break;
                    case "3":
                        Console.WriteLine("Enter AccountId");
                        bank.Deposit();
                        break;
                    case "4":
                        Console.WriteLine("Enter AccountId");
                        bank.Withdrawn();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                if (input == "6")
                {
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
