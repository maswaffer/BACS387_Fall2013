using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Drin.Engine
{
    public class Tank
    {
        public Tank()
        {
            ConfiguredTriggers = new List<ITrigger>();
        }

        private List<ITrigger> ConfiguredTriggers { get; set; }

        public void Fill(ITrigger trigger)
        {
            ConfiguredTriggers.Add(trigger);
        }

        public void Fill(IList<ITrigger> triggers)
        {
            ConfiguredTriggers.AddRange(triggers);
        }
    }
}
