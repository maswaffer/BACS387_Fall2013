using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Barabara.Liskov
{
    public class RandomNumber
    {
        
        /*
         * will generate a random number
         * take number and let pokedex check it
         */
       // public static Random rand = new Random();
        //public int Number = rand.Next(1, 150);
        public int GetNumber()
        {
            var RandomGenerator = new Random(DateTime.Now.Millisecond);
            var Number = RandomGenerator.Next(1, 150);
            return Number;
             
             // 4; 
        }
    




    }
}
