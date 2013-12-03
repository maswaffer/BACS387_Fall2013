using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barabara.Liskov
{
     public class Pokemon  
    {
         public int PokedexNumber { get; set; }
         public string Name { get; set; }
         public int Height { get; set; }
         public int Weight { get; set; }

         public override string ToString()
         {
             
             return string.Format ("PokedexNumber: {0}, Name: {1}, Weight: {3}, Height: {4}", PokedexNumber, Name, Weight, Height);
         }



         
    }
}
