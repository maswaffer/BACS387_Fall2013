using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Woot
{
    class WootService
    {
        internal object GetEvents(object p1, object p2)
        {
            throw new NotImplementedException();
        }
        public class EventType
        { public static object tools { get; set; } }

        public class EventSites
        { public static object Daily { get; set; } }

        public class GetEvents
        { public static object Items { get; set; } }
    }
}
