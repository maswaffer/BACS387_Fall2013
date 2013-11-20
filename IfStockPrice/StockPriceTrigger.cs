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
        public StockPriceTrigger(string symbol)
        {
            Symbol = symbol;
            Service = new TraderService();
            Criteria = new List<ICriteria<Stock>>();
        }

        private string Symbol { get; set; }
        private List<ICriteria<Stock>> Criteria { get; set; }
        private TraderService Service { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            Criteria.Add(criteria as ICriteria<Stock>);
        }

        #region ITriggerImplementation

        public string Message { get; set; }

        public bool CheckCondition()
        {
            var quote = Service.GetStockQuote(Symbol);
            foreach (var criteria in Criteria)
            {
                var isMet = criteria.Check(quote);
                if (isMet)
                {
                    Message = criteria.Message;
                    return true;
                }
            }
            return false;
        }

        #endregion

        public override string ToString()
        {
            var criteriaDescriptions = new List<string>();
            foreach (var c in Criteria)
            {
                criteriaDescriptions.Add(c.ToString());
            }

            return "Stock " + string.Join(" or ", criteriaDescriptions);
        }


    }
}
