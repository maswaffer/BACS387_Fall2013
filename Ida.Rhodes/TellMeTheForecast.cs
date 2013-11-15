using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class TellMeTheForecast
    {
        public Forecast GetForecast(int zipcode)
        {
            /*
             * Go to WU API
             * check condition for zipcode
             * build Stock object
             * return
             */

            return new Forecast
            {
                ChanceOfPrecip = 50,
                HighTemp = 15,
                LowTemp = 40,
                Timestamp = DateTime.Now,
                ZipCode = zipcode
            };
        }
    }
}
