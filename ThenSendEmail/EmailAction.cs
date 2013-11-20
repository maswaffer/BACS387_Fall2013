using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ThenSendEmail
{
    public class EmailAction : IAction
    {
        public EmailAction()
        {
            Service = new EmailService();
        }

        public string Recipient { get; set; }

        private EmailService Service { get; set; }

        public void SendNotification(string message)
        {
            Service.SendEmail(Recipient, message);
        }

        public override string ToString()
        {
            var message = string.Format("Send email to {0}", Recipient);
            return message;
        }
    }
}
