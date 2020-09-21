using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Registration
{
    public class Mail
    {
        public static void SendEmail()
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smptClient = new SmtpClient();
                mailMessage.From = new MailAddress("email@email");
                mailMessage.To.Add(new MailAddress("email@email"));
                mailMessage.Subject = "Single Responsibility Demo";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "We will be discussing SOLID";
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
