using System;
using System.Collections.Generic;
using System.Linq;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. See User List");
            Console.WriteLine("4. Exit");
            var r = new Register();
            var l = new Login();
            var users = new List<Person>();
            var p = new Person
            {
                FirstName = "Kasparas",
                LastName = "Jurkevicius",
                Email = "kasparas.jurkevicius@euromonitor.com",
                UserName = "kasparas92",
                Password = "Qwertyuiop1@",
                IsLocked = false
            };
            int input;
            while ((input = Convert.ToInt32(Console.ReadLine())) != 4)
            {
                switch (input)
                {
                    case 1:
                        users.Add(r.StartRegistration(users));
                        break;
                    case 2:
                        l.StartLogin(users);
                        break;
                    case 3:
                        foreach(var u in users)
                        {
                            Console.WriteLine($"FirstName: {u.FirstName}");
                            Console.WriteLine($"LastName: {u.LastName}");
                            Console.WriteLine($"Email: {u.Email}");
                            Console.WriteLine($"UserName: {u.UserName}");
                            Console.WriteLine($"Is locked: {u.IsLocked}");
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("What do you want to do?");
            }
        }
    }
}
