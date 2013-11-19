using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class Forecast
    {
        public DateTime Timestamp { get; set; }
        public string ZipCode { get; set; }
        public int HighTemp { get; set; }
        public int LowTemp { get; set; }
        public int ChanceOfPrecip { get; set; }
    }
}
