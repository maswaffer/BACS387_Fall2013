using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barabara.Liskov
{
    public class NameMatchCriteria : ICriteria<Pokemon> 
    {
        public string Name { get; set; }
        public bool Check(Pokemon pokmeoncompare)
        {
            var Match = pokmeoncompare.Name == Name.ToLower();
            if (Match)
            {
                Message = "Found Match";
            }
            return Match;
        }
        public string Message {get; set; }


    }
}
