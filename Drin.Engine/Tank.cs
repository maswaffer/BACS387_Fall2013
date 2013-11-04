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
            Rules = new List<Rule>();
        }

        private List<Rule> Rules { get; set; }

        public void Fill(Rule rule)
        {
            Rules.Add(rule);
        }

        public void Fill(IList<Rule> rules)
        {
            Rules.AddRange(rules);
        }
    }
}
