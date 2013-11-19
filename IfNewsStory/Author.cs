using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    class Author : ICriteria 
    {
        public string author { get; set; }


        public Author(string authorInput)
        {
            author = authorInput; 
        }
    }
}
