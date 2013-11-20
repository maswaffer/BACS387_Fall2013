using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Rule
    {
        public Rule(ITrigger trigger, IAction action)
        {
            Trigger = trigger;
            Action = action;
        }

        public ITrigger Trigger { get; private set; }
        public IAction Action { get; private set; }

        public override string ToString()
        {
            var str = string.Format("IF[{0}] THEN[{1}]", Trigger.ToString(), Action.ToString());
            return str;
        }
    }
}
