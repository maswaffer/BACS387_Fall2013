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
        public StockPriceTrigger(string symbol, ICriteria criteria)
        {
            StockBroker = new Broker(symbol, criteria);
        }

        private Broker StockBroker { get; set; }
        private ICriteria Criteria { get; set; }
        public string Message { get; set; }

        public bool CheckCondition()
        {
            var check = StockBroker.CheckStock();
            if (check.IsCriteriaMet)
            {
                Message = check.Criteria.Message;
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return "If stock " + Criteria.ToString();
        }
    }
}
