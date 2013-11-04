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
        /*
         * I have 2 different constructors here for 2 possible different uses
         */
        public StockPriceTrigger(string symbol){
            StockBroker = new Broker(symbol);
        }

        public StockPriceTrigger(string symbol, ICriteria criteria)
        {
            StockBroker = new Broker(symbol, criteria);
        }


        private Broker StockBroker { get; set; }
        private ICriteria Criteria { get; set; }

        public void AddCriteria(ICriteria criteria)
        {
            StockBroker.AddCriteria(criteria);
        }

        #region ITriggerImplementation

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

        #endregion

        public override string ToString()
        {
            return "If stock " + Criteria.ToString();
        }
    }
}
