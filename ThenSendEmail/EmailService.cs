using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ThenSendEmail
{
    public class EmailService
    {
        public void SendEmail(string recipient, string message)
        {
            try
            {
                var email = new MailMessage("bacs387@outlook.com", recipient);
                email.Subject = "If this then that message";
                email.Body = message;

                var client = new SmtpClient("smtp.live.com", 587);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("bacs387@outlook.com", "B@cs387!");
                client.Send(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
