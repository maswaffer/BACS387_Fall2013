using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Barabara.Liskov;

namespace PokemonFile.Test
{
    [TestClass]
    public class PokemonFileTest
    {
        
        
        
        [TestMethod]
        public void ShouldReadPokemonFile()
        {
            var File = new Barabara.Liskov.PokemonFile();
            var PokemonList = File.GetPokemon();

            Assert.AreEqual(778, PokemonList.Count);

            
        }
    }
}
