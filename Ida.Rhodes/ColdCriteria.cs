using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class ColdCriteria : ICriteria<Forecast>
    {
        public string Name
        {
            get { return "Will it be cold today?"; }
            set { }
        }

        public string AboveOrBelow { get; set; }
        public string Message { get; set; }
        public int UserTemp { get; set; }

        public bool Check(Forecast latest)
        {
            if (AboveOrBelow == "Below")
                if (latest.HighTemp < 35) //we'll replace 35 with UserTemp
                {
                    Message = string.Format("Cold today, with a high temperature of {0} degrees.  ", latest.HighTemp);
                    return true;
                }

            else if(AboveOrBelow == "Above")
                if (latest.HighTemp >= 35) //we'll replace 35 with UserTemp
                {
                    Message = string.Format("Warm today, with a high temperature of {0} degrees.  ", latest.HighTemp);
                    return true;
                }            
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
