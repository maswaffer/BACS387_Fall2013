using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace IfStockPrice
{
    public class PriceChangeGreaterThan : ICriteria<Stock>
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public bool Check(Stock value)
        {
            var met = false;
            if (PercentChange > 0)
            {
                met = value.ChangePercent > PercentChange;
            }
            else
            {
                met = value.ChangePercent < PercentChange;
            }
            Message = met ? string.Format("{0} changed by {1}.  You asked to be notified of changes greater than {2}", value.Symbol, value.ChangePercent, PercentChange) : "";

            return met;
        }

        public decimal PercentChange { get; set; }

        public override string ToString()
        {
            var str = string.Format("Price change is greater than {0}%", PercentChange);
            return str;
        }

    }
}
