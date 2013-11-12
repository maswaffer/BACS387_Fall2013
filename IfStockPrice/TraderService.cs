using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public class TraderService
    {
        public Stock GetStockQuote(string symbol)
        {
            /*
             * Go to stock API
             * check quote for symbol
             * build Stock object
             * return
             */
            return new Stock
            {
                High = 100,
                Quote = 101
            };
        }
    }
}
