using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registration
{
    public class Login
    {
        public void StartLogin(List<Person> people)
        {
            Console.WriteLine("Enter your User Name: ");
            string input = Console.ReadLine();
            var userNames = people.Select(x => x.UserName).ToList();
            while(!CheckIfUserNameOrPasswordPresent(userNames, input))
            {
                Console.WriteLine("User Name is not pressent! Please enter Valid one!");
                input = Console.ReadLine();
            }
            var userName = input;
            var passwords = people.Select(x => x.Password).ToList();
            var attempt = 0;
            var person = people.SingleOrDefault(x => x.UserName == userName);
            var time = DateTime.Now;
            var index = people.IndexOf(person);
            if (person.LastLockedDate != null)
            {
                time = (DateTime)person.LastLockedDate;
            }
            if (person.IsLocked && time.AddMinutes(3) < DateTime.Now)
            {
                person.IsLocked = false;
                person.LastLockedDate = null;
                people[index] = person;
            }
            if (person.IsLocked)
            {
                Console.WriteLine("Your account is locked");
            }
            else
            {
                Console.WriteLine("Enter your Password: ");
                input = Console.ReadLine();
                while (!CheckIfUserNameOrPasswordPresent(passwords, input))
                {
                    attempt++;
                    if (attempt > 3)
                    {
                        time = DateTime.Now;
                        Console.WriteLine($"Your account has been locked, because of 3 failed attempts. Try after 3min. Current time is {time}");
                        person.IsLocked = true;
                        person.LastLockedDate = time;
                        people[index] = person;
                        break;
                    }
                    Console.WriteLine("Password is incorrect!");
                    input = Console.ReadLine();
                }
            }
            if (attempt <= 3 && !person.IsLocked)
            {
                Console.WriteLine("You have successfully logged in!");
            }
            
        }
        private bool CheckIfUserNameOrPasswordPresent(List<string> inputs, string input)
        {
            foreach(var u in inputs)
            {
                if (u.Equals(input))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
