using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drin.Engine
{
    public class Motor
    {

        public event Action<string> CheckingRule;
        public event Action<string> NotificationSent;
        public event Action<string> StatusUpdate;

        public void Start()
        {
            if (CheckingRule == null || NotificationSent == null || StatusUpdate == null)
                return;

            //Do this forever
            while (true)
            {
                StatusUpdate("Checking rules");
                //Check each configured rule
                foreach (var rule in Tank)
                {
                    CheckingRule(rule.ToString());
                    //Check the condition
                    if (rule.Trigger.CheckCondition())
                    {
                        NotificationSent(rule.Trigger.Message);
                        //Send notification
                        rule.Action.SendNotification(rule.Trigger.Message);
                    }
                }
                StatusUpdate("Waiting");
                //Wait 30 seconds before doing it again
                Thread.Sleep(30000);
            }
        }

        public Tank Tank { get; set; }
    }
}
