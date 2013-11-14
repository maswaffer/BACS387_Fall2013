using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Woot
{
    public class Action  
    {
        public bool Keyword { get; set; }
        //this trigger will pull any item from Woot that matches the criteria of date, being new or EOL(End Of Life), or price (dealing with deals). 
        //It will then send back a notification, matching the criteria, back to the user.

         static void Main(string[] args)
        {
            Console.WriteLine("Searching Criteria");
            var service = new WootService();
            var events = service.GetEvents(WootService.EventType.tools, WootService.EventSites.Daily);

            var one = events.one();
            foreach (var offer in one.Offers)
            {
                Console.WriteLine(offer.Title);
                Console.WriteLine(offer.Features);
                foreach (var item in offer.Items)
                {
                    Console.WriteLine("Sale Price:" + item.SalePrice);
                }
            }
            Console.ReadKey();
        }
    }
}
