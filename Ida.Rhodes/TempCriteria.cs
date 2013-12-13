using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class TempCriteria : ICriteria<Forecast>
    {
        public string Name
        {
            get { return "It's so damn hot... milk was a bad choice. -Ron Burgundy"; }
            set { }
        }

        public string tempAboveOrBelow { get; set; }
        public string Message { get; set; }
        public int userTempValue { get; set; }

        public bool Check(Forecast latest)
        {
            if (tempAboveOrBelow == "Below")
            {
                if (latest.LowTemp < userTempValue)
                {
                    Message = string.Format("Cold today, with a high temperature of {0} degrees.  ", latest.HighTemp);
                    return true;
                }
            }

            else if (tempAboveOrBelow == "Above")
                if (latest.HighTemp >= userTempValue)
                {
                    Message = string.Format("Warmer today, with a high temperature of {0} degrees.  ", latest.HighTemp);
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
