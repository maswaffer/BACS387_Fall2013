using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Ida.Rhodes
{
    public class TellMeTheForecast
    {
        public Forecast GetForecast(string zipcode)
        {
            var hourlies = GetHourlies(zipcode);
            //For ChanceOfPrecip, get max HourlyChanceOfPrecip from hourlies --CH
            //For HighTemp, get max HourlyTemp from hourlies --CH
            //For LowTemp, get min HourlyTemp from hourlies --CH

            Forecast Latest;
            Latest = new Forecast();
            
                Latest.ChanceOfPrecip = 0; //max HourlyChanceOfPrecip --CH
                Latest.HighTemp = 15;  //max HourlyTemp --CH
                Latest.LowTemp = 40;  //min HourlyTemp --CH
                Latest.Timestamp = DateTime.Now;
                Latest.ZipCode = zipcode;
            
            return Latest;
        }
        
        public List<Forecast> GetHourlies(string zipcode)
        {
                //These pull the City and state using the ZipCode
                var ZipCode = zipcode;

                //This bulds the API call using the apiKey, City, State, etc.
                var apiKey = "9a709d3a540125fd";
                var url = @"http://api.wunderground.com/api/{0}/hourly/q/{1}.xml";
                var urlFixed = string.Format(url, apiKey, ZipCode);

                //Calls the API and retrieves the XML file that is parsed.
                var client = new WebClient();
                var response = client.DownloadString(urlFixed);
                var xml = XElement.Parse(response);
            
                //builds forecasts using the parsed XML information
                var forecasts = (from el in xml.Descendants("forecast")
                               select new Forecast
                               {
                                   //I dont think we need the datetime from each hourly do we?  --CH
                                   //We'll just say "there's rain in the forecast" or "its gonna be above/below 'X'" --CH
                                   /*Timestamp = new DateTime(
                                                            Convert.ToInt32(el.Descendants("year").First().Value),
                                                            Convert.ToInt32(el.Descendants("mon").First().Value),
                                                            Convert.ToInt32(el.Descendants("mday").First().Value),
                                                            Convert.ToInt32(el.Descendants("hour").First().Value),
                                                            Convert.ToInt32(el.Descendants("min").First().Value),
                                                            Convert.ToInt32(el.Descendants("sec").First().Value)
                                                            ),*/
                                   HourlyChanceOfPrecip = Convert.ToInt32(el.Descendants("pop").FirstOrDefault().Value),
                                   HourlyTemp = Convert.ToInt32(el.Descendants("english").FirstOrDefault().Value)
                               }).ToList();
                return forecasts;            
        }
            
            

            //public int Precipitation()
            //{
            //    int rainChance = 
            //}

            //public string[] GetLocation(string zipcode)
            //{
            //    var zipURL = @"http://ziptasticapi.com/{0}";
            //    var zipURLFixed = string.Format(zipURL,zipcode);
            //    var zipClient = new WebClient();
            //    var zipResponse = zipClient.DownloadString(zipURLFixed);

            //    string[] CityState = {"Greeley", "CO"};

            //    return CityState;
            //}
        
    }
}
