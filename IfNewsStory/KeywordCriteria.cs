using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    public class KeywordCriteria : ICriteria<Story>
    {
        //ICriteria
        public string Name { get; set; }
        public string Message { get; set; }

        public bool Check(Story value)
        {
            
            throw new NotImplementedException();
        }

        //Specific to our criteria
        public string Keyword { get; set; }

    }
}
