using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public class Broker
    {
        public TraderService Service { get; set; }
        public TimeSpan Delay { get; set; }

        private List<Stock> Quotes { get; set; }
        private List<ICriteria> Criteria { get; set; }

        public void AddCriteria(ICriteria criteria)
        {
            //Add criteria to private list
        }

        public BrokerMessage CheckStock()
        {
            /*
             * If last check was longer ago than delay, check for new quote
             * If new quote is received,
             * For each criteria, check the values
             * If match is found, return true
             * else return false
             */
            //todo add symbol

            throw new NotImplementedException();
        }

        public class BrokerMessage
        {
            public bool IsCriteriaMet { get; set; }
            public ICriteria Criteria { get; set; }
        }
    }
}
