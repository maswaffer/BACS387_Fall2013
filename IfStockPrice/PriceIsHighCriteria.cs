using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public class PriceIsHighCriteria : ICriteria
    {
        public string Message { get; set; }

        

        public bool Check(Stock value)
        {
            /*
             * Check to see if stock price is equal to high for day
             * if yes, set message and  return true
             * else return false
             */
            throw new NotImplementedException();
        }
    }
}
