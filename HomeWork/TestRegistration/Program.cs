using System;

namespace TestRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Register();
            var attempt = 0;
            var isValid = false;
            int input;
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Leave");
            while ((input = Convert.ToInt32(Console.ReadLine())) != 4)
            {
                switch (input)
                {
                    case 1:
                        if (!r.IsLocked)
                        {
                            while (!isValid)
                            {
                                Console.WriteLine("Enter your UserName: ");
                                r.UserName = Console.ReadLine();
                                var isValidUserName = r.ValidateUserName();

                                Console.WriteLine("Enter your Password: ");
                                r.Password = Console.ReadLine();
                                var isValidPassword = r.ValidatePassword();
                                if (isValidUserName && isValidPassword)
                                {
                                    isValid = true;
                                    Console.WriteLine($"{r.UserName} you are successfully registered!!");
                                }
                                else
                                {
                                    Console.WriteLine(new Exception("Username or Password does not match criteria!!!!!!\n 1. UserName: max length 6,1 numeric,1 Special character,1 capital letter is mandatory \n 2. Pswd: max length 7,1 numeric,1 special character is mandatory"));
                                }
                                attempt++;
                                if (attempt == 3 && !isValid)
                                {
                                    Console.WriteLine("Exceed the maximum limit.");
                                    Console.WriteLine("Try after 2 min.");
                                    r.IsLocked = true;
                                    r.LockedDate = DateTime.Now;
                                    isValid = true;
                                }
                            }
                        }
                        else if (r.IsLocked && r.LockedDate.AddMinutes(2) < DateTime.Now)
                        {
                            r.IsLocked = false;
                            Console.WriteLine("Your account was unlocked");

                        }
                        else
                        {
                            Console.WriteLine("Your account is still locked.");
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("What do you want to do?");
            }
           
            Console.ReadLine();
        }
    }
    public class Register
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; } = false;
        public DateTime LockedDate { get; set; }
        public bool ValidatePassword()
        {
            var isDigit = false;
            var isSymbol = false;
            var specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            foreach (var c in Password)
            {
                if (char.IsDigit(c))
                {
                    isDigit = true;
                }
                if (specialChar.Contains(c))
                {
                    isSymbol = true;
                }
            }

            if (isDigit && isSymbol && Password.Length <= 7)
            {
                return true;
            }
            return false;
        }
        public bool ValidateUserName()
        {
            var isUpperCase = false;
            var isDigit = false;
            var isSymbol = false;
            var specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            foreach (var c in UserName)
            {
                if (char.IsDigit(c))
                {
                    isDigit = true;
                }
                if (char.IsUpper(c))
                {
                    isUpperCase = true;
                }
                if (specialChar.Contains(c))
                {
                    isSymbol = true;
                }
            }

            if (isUpperCase && isDigit && isSymbol && UserName.Length <= 6)
            {
                return true;
            }
            return false;
        }
    }
}
