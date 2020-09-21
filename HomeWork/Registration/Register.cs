using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Registration
{
    public class Register
    {
        public Person StartRegistration(List<Person> people)
        {
            var p = new Person();
            string input;

            Console.WriteLine("Enter your First Name: ");
            p.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            p.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            input = Console.ReadLine();
            var emails = people.Select(x => x.Email).ToList();
            while (!p.ValidateEmail(input, emails))
            {
                Console.WriteLine("Enter your Email AGAIN: ");
                input = Console.ReadLine();
            }
            p.Email = input;
            Console.WriteLine("Enter your User Name");
            input = Console.ReadLine();
            while (!p.ValidateUserName(input))
            {
                Console.WriteLine("Enter your UserName AGAIN: ");
                input = Console.ReadLine();
            }
            p.UserName = input;
            Console.WriteLine("Enter your Password: ");
            input = Console.ReadLine();
            while (!p.ValidatePassword(input))
            {
                Console.WriteLine($"{new Exception("Email Already Registered!!!!")}");
                input = Console.ReadLine();
            }
            p.Password = input;
            Console.WriteLine("Confirm your Password: ");
            input = Console.ReadLine();
            while (!p.ValidateConfirmPassword(input))
            {
                Console.WriteLine("Confirm your Password:(password and confirm password does not match!!!!!) ");
                input = Console.ReadLine();
            }
            //SendEmail(p); --Commented because not Working!!!!
            return p;
        }

        public void SendEmail(Person person)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smptClient = new SmtpClient();
                mailMessage.From = new MailAddress("support@gmail.com");
                mailMessage.To.Add(new MailAddress(person.Email));
                mailMessage.Subject = "Registration";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = $"You have successfully registered {person.UserName}";
                smptClient.Port = 587;
                smptClient.Host = "smtp-mail.outlook.com";
                smptClient.EnableSsl = true;
                smptClient.UseDefaultCredentials = false;
                smptClient.Credentials = new NetworkCredential("email@email", "password");
                smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smptClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred" + e.Message);
            }
        }
    }
}
