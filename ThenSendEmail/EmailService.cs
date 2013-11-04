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
            var email = new MailMessage("maswaffer@gmail.com", recipient);
            email.Subject = "If this then that message";
            email.Body = message;

            var client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 465;
            client.Credentials = new NetworkCredential("xxxxxxx@gmail.com", "yyyyyy");
            client.Send(email);
        }
    }
}
