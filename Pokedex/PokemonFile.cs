﻿using System;
using System.Collections.Generic;
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
            //return new Pokemon { Name = "Charmeleon", PokedexNumber = 5, Height = 11, Weight = 90 };
            // put code in to return null for now
            // want to CONNOR DO CODE FOR THIS
            return null;
        }

    }
}
