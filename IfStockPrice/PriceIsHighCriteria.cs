using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public class PriceIsHighCriteria : ICriteria
    {
        public string Name
        {
            get { return "Price >= Daily High"; }
            set { }
        }

        public string Message { get; set; }

        public bool Check(Stock value)
        {
            if (value.Quote >= value.High)
            {
                Message = string.Format("{0}: Quote {1} was equal to or greater than high of {2} for day", value.Symbol, value.Quote, value.High);
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
