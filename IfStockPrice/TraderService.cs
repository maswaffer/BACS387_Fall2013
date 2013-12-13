using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IfStockPrice
{
    public class TraderService
    {
        public Stock GetStockQuote(string symbol)
        {
            /*
             * Go to stock API
             * check quote for symbol
             * build Stock object
             * return
             */
            var yql = @"http://query.yahooapis.com/v1/public/yql?q=";
            var q = Uri.EscapeDataString(string.Format("select * from yahoo.finance.quotes where symbol = \"{0}\"", symbol));
            var url = yql + q + "&env=http%3A%2F%2Fdatatables.org%2Falltables.env";

            Console.WriteLine(url);

            var client = new WebClient();
            var response = client.DownloadString(url);
            var el = XElement.Parse(response);

            var stock = el.Descendants("quote").First();

            return new Stock
            {
                High = Convert.ToDecimal(stock.Element("DaysHigh").Value),
                Quote = Convert.ToDecimal(stock.Element("LastTradePriceOnly").Value),
                ChangePercent = Convert.ToDecimal(stock.Element("Change").Value),
                Low = Convert.ToDecimal(stock.Element("DaysLow").Value),
                Symbol = symbol,
                Timestamp = DateTime.Now,
                Volume = Convert.ToInt32(stock.Element("Volume").Value)
            };
            
        }
    }
}
