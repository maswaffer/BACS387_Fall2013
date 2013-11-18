using Common;
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

        public string tempAboveOrBelow { get; set; }
        public string Message { get; set; }
        public int userTempValue { get; set; }

        public bool Check(Forecast latest)
        {
            if (tempAboveOrBelow == "Below")
                if (latest.HighTemp < userTempValue) //we'll replace 35 with UserTemp
                {
                    Message = string.Format("Cold today, with a high temperature of {0} degrees.  ", latest.HighTemp);
                    return true;
                }

            else if(tempAboveOrBelow == "Above")
                    if (latest.HighTemp >= userTempValue) //we'll replace 35 with UserTemp
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
