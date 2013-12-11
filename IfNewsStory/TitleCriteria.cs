using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    public class TitleCriteria : ICriteria<Story>
    {
        //ICriteria
        public string Name { get; set; }

        public string Message { get; set; }
        public DateTime Date { get; set; }
        
        public string Keyword { get; set; }


        public bool Check(Story value)
        {
            bool match = false; 
            if (value.Title.Contains(Keyword))
            {
                //if (value.storyDate.Equals(Date))
                if (value.storyDate.Date.Equals(Date.Date))
                {
                    match = true;
                }
                else
                {
                    match = false; 
                }
            }
            else
            {
                match = false; 
            }
            return match; 
        }

        public override string ToString()
        {
            var str = string.Format("Title");
            return str;
        }


    }
}
