using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Woot
{
    class WootService
    {
        private readonly string WootKey = "ec5dfd9da86540feb4e0d97482c12acc";

        public List<Event> GetEvents(string site)
        {
            var url = @"http://api.woot.com/2/events.json";
            var queryString = string.Format("?site={0}&key={2}", site, WootKey);

            var fullUrl = url + queryString;
            Console.WriteLine(fullUrl);

            var client = new WebClient();

            var response = client.DownloadString(fullUrl);

            Debug.WriteLine(response);
         
            var list = JsonConvert.DeserializeObject<List<Event>>(response);

            return list;
        }
    }

    /*
     * These two classes simply define the valid string values that you can use with the API
     * You don't have to use these... you can just put regular strings in your code, but if you 
     * do this, it makes a nice convenient place to store all of your "magic strings"
     */

    public class EventType
    {
        public const string Daily = "Daily";
        public const string Moofi = "Moofi";
        public const string Reckoning = "Reckoning";
        public const string WootOff = "WootOff";
        public const string WootPlus = "WootPlus";
    }

    public class EventSites
    {
        public const string Woot = "www.woot.com";
        public const string Wine = "wine.woot.com";
        public const string Shirt = "shirt.woot.com";
        public const string Sellout = "sellout.woot.com";
        public const string Kids = "kids.woot.com";
        public const string Home = "home.woot.com";
        public const string Sport = "sport.woot.com";
        public const string Tech = "tech.woot.com";
        //public const string Pop = "pop.woot.com";
        public const string Tools = "tools.woot.com";
        public const string Accessories = "accessories.woot.com";
    }
}
