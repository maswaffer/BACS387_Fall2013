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
            if (PercentChange > 0)
            {
                return value.ChangePercent > PercentChange;
            }
            else
            {
                return value.ChangePercent < PercentChange;
            }
        }

        public decimal PercentChange { get; set; }

    }
}
