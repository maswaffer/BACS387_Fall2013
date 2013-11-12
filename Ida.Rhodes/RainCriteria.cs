using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class RainCriteria : ICriteria<Forecast>
    {
        public string Name 
        {
            get { return "Will it rain today?"; }
            set { }
        }

        public string Message { get; set; }

        public bool Check(Forecast value)
        {
            if (value.ChanceOfPrecip >= 50)
            {
                Message = string.Format("The latest forecast calls for a {0}% chance of precipitation", value.ChanceOfPrecip);
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
