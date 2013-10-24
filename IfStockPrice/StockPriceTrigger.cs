using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace IfStockPrice
{
    public class StockPriceTrigger : ITrigger
    {
        public Broker StockBroker { get; set; }

        public bool CheckCondition()
        {
            /*
             * Ask broker to check for quote
             * Ask broker if any criteria were met
             * If so, set message and return true 
             * If no, return false
             */
            throw new NotImplementedException();
        }
    }
}
