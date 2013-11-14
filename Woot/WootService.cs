using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Woot
{
    class WootService
    {

        public class EventType
        { public static object Tools { get; set; } }

        public class EventSites
        { public static object Daily { get; set; } }

        public class GetEvents
        { public static object Events { get; set; } }
    }
}
