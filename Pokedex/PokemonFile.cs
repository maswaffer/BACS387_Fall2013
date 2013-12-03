using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barabara.Liskov
{
    public class PokemonFile
    {
        /*
         * get infromation from pokemon file online
         * use number given from random number generator
         * https://github.com/veekun/pokedex/blob/master/pokedex/data/csv/pokemon.csv
         * from this site
         * charmeleon	id: 5	height: 11	weight :190
         */
        private readonly string DataFileName = "Pokemon.csv";

        public List<Pokemon> GetPokemon()
        {
            List<Pokemon> finalList = new List<Pokemon>();
            //return new Pokemon { Name = "Charmeleon", PokedexNumber = 5, Height = 11, Weight = 90 };
            // put code in to return null for now
            var lines = File.ReadAllLines(DataFileName);

            foreach (var line in lines)
            {
                //This splits the line by commas into an array of strings. 
                var splitByCommas = line.Split(',');
                var species = new Pokemon
                {
                    PokedexNumber = Convert.ToInt32(splitByCommas[0]),
                    Name = splitByCommas[1],
                    Height = Convert.ToInt32(splitByCommas[3]),
                    Weight = Convert.ToInt32(splitByCommas[4])
                };
                finalList.Add(species);
            }


            return finalList;
        }

     }
}
