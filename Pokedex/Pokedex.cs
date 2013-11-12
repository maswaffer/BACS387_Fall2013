using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pokedex : ITrigger 
    {
        // constructor has same name as class, no return value
        public Pokedex()
        {
            Criteria = new List<ICrteria>();
            var Fake = new NameMatchCriteria();
            Fake.Name = "Charmeleon";
            Criteria.Add(Fake);
            GetNumber = new RandomNumber();
            File = new PokemonFile();
        }

        public Pokedex(List<ICrteria> criteria)
        {
            Criteria = criteria;
        }
        public string Message { get; set; }
        public RandomNumber GetNumber { get; set; }
        public PokemonFile File { get; set; }

        public List <ICrteria> Criteria{get; set;}
    
        public bool Check()
        {
            /*
             * get number from random generator
             * check if pokemon exists
             * if pokemon exists, check its info
             * if not, return false
             * if pokemon exists, get pokmeon info from file
             * if not, dont fire trigger
             */
            var number = GetNumber.GetNumber();
            var pokemon = File.GetPokemon(number);

            foreach (var Info in Criteria)
            {
                if (Info.Matches (pokemon))
                {
                    Message = pokemon.ToString();
                    return true;
                }
            }
            return false;
        }
        
         
           
            
        
    }
}
