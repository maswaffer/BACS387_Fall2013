using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms.VisualStyles;
using Common;

namespace Woot
{
   public class ActionTrigger : ITrigger  
    {
       public bool CheckCondition()
       {
           var service = new WootService();
           var events = service.GetEvents("www.woot.com");
           bool x = false;

           foreach (var e in events)
           {
               if (Criteria.Check(e))
               {
                   Message += Criteria.Message;
                   x = true;
               }
           }
           return x;
       }

       public string Message { get; set; }

       private Criteria Criteria { get; set; }

       public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
       {
           Criteria = criteria as Criteria;
       }
    }
}
