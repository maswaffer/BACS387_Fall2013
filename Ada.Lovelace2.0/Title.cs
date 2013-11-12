using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    class Title : ICriteria 
    {
        public string title { get; set; }

        public Title(string titleInput)
        {
            title = titleInput; 
        }
    }
}
