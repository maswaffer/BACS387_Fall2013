using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    class Keyword : ICriteria 
    {
        public string keyword { get; set; }


        public Keyword(string keywordInput)
        {
            keyword = keywordInput; 
        }
    }
}
