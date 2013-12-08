using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Woot
{
    public class Criteria : ICriteria<Event>
    {
        //Error checking will ensure that all input will return the proper data
        //This method will check letters, numbers, and other character inputs
        //If True then the method will continue

        public string Keyword { get; set; }
        //public string Category { get; set; }

        public string Name { get; set; }

        public bool Check(Event value)
        {
            //if (value.Title.Contains(Keyword))
            if (value.Title.ToUpper().Contains(Keyword.ToUpper()))
            {
                Message = "The item matching your keyword: " + value.Title;
                return true;
            }
            {
                return false;
            }
        }

        public string Message { get; set; }
    }
}
