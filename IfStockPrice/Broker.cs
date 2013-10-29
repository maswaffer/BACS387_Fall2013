using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public class Broker
    {
        public Broker(string symbol, List<ICriteria> criteria)
        {
            Service = new TraderService();
            Delay = new TimeSpan(0, 0, 10);
            Symbol = symbol;
            Criteria = criteria;
        }

        private string Symbol { get; set; }

        private TraderService Service { get; set; }
        private TimeSpan Delay { get; set; }
        private DateTime LastCheck { get; set; }
        private List<Stock> Quotes { get; set; }
        private List<ICriteria> Criteria { get; set; }

        public BrokerMessage CheckStock()
        {
            var timeSinceLast = DateTime.Now - LastCheck;
            if (timeSinceLast.TotalMilliseconds < Delay.TotalMilliseconds)
            {
                return new BrokerMessage();
            }
            var quote = Service.GetStockQuote(Symbol);
            if (quote == null)
            {
                return new BrokerMessage();
            }

            foreach (var criteria in Criteria)
            {
                if (criteria.Check(quote))
                {
                    return new BrokerMessage
                    {
                        Criteria = criteria,
                        IsCriteriaMet = true
                    };
                }
            }
            return new BrokerMessage();
        }

        public class BrokerMessage
        {
            public bool IsCriteriaMet { get; set; }
            public ICriteria Criteria { get; set; }
        }
    }
}
