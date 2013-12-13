using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public class Stock
    {
        public DateTime Timestamp { get; set; }
        public string Symbol { get; set; }
        public decimal Quote { get; set; }
        public int Volume { get; set; }
        public decimal ChangePercent { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
    }
}
