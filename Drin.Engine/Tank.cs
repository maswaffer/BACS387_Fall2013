using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Drin.Engine
{
    public class Tank : List<Rule>
    {
     
        public void Fill(Rule rule)
        {
            this.Add(rule);
        }

        public void Fill(IList<Rule> rules)
        {
            this.AddRange(rules);
        }
    }
}
