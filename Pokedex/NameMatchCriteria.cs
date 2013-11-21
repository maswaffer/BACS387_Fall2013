using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barabara.Liskov
{
    public class NameMatchCriteria : ICrteria 
    {
        public string Name { get; set; }
        public bool Matches(Pokemon pokmeoncompare)
        {
            var Match = pokmeoncompare.Name == Name;
            if (Match)
            {
                Message = "Found Match";
            }
            return Match;
        }
        public string Message {get; set; }
        
        
    }
}
