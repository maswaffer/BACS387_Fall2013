
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barabara.Liskov
{
    public class PokedexNumberMatchCriteria : ICriteria<Pokemon>
    {
        public int Number { get; set; }
        public bool Check(Pokemon pokmeoncompare)
        {
            var Match = pokmeoncompare.PokedexNumber == Number;
            if (Match)
            {
                Message = "Found Match";
            }
            return Match;
        }
        public string Message { get; set; }
        public override string ToString()
        {
            return "Pokedex Number Match";
        }
    }
}
