using System;
using System.Collections.Generic;
using System.Text;

namespace Registration
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }
        public DateTime? LastLockedDate { get; set; }

        public Person()
        {
            IsLocked = false;
        }

        public bool ValidateEmail(string email, List<string> emails)
        {
            if (emails.Contains(email) || !email.Contains('@'))
            {
                return false;
            }
            return true;
        }
        public bool ValidateUserName(string userName)
        {
            foreach(var c in userName)
            {
                if (char.IsLower(c) || char.IsDigit(c))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool ValidateConfirmPassword(string password)
        {
            if (Password.Equals(password))
            {
                return true;
            }
            return false;
        }
        public bool ValidatePassword(string password)
        {
            var isUpperCase = false;
            var isDigit = false;
            var isSymbol = false;

            foreach(var c in password)
            {
                if(char.IsDigit(c))
                {
                    isDigit = true;
                }
                if (char.IsUpper(c))
                {
                    isUpperCase = true;
                }
                if (c == '#' || c == '_')
                {
                    isSymbol = true;
                }
            }

            if(isUpperCase && isDigit && isSymbol && password.Length == 12)
            {
                return true;
            }
            return false;
        }
    }
}
