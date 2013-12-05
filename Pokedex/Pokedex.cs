using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Barabara.Liskov
{
    public class Pokedex : ITrigger 
    {
        // constructor has same name as class, no return value
        public Pokedex()
        {

            var NameMatch = new NameMatchCriteria();
            //Fake.Name = "Charmeleon";
           // var NumberMatch = new PokedexNumberMatchCriteria();
            Criteria = NameMatch;
            //Criteria = NumberMatch;
            GetNumber = new RandomNumber();
            File = new PokemonFile();
        }


        public string Message { get; set; }
        public RandomNumber GetNumber { get; set; }
        public PokemonFile File { get; set; }
        //used icriteria<pokemon> because pokemon is a strongly written format of type T to be set as 
        public ICriteria<Pokemon> Criteria { get; set; }

        public bool CheckCondition()
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
            var PokemonList = File.GetPokemon();

            foreach (var pokemon in PokemonList)
            {
                if (Criteria.Check(pokemon))
                {
                    Message = pokemon.ToString();
                    return true;
                }
            }


            return false;
        }


        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            Criteria = criteria as ICriteria<Pokemon>;
        }
    }
}
