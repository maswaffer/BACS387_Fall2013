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

    /*“I’m Brick Tamland. People seem to like me because I’m polite and I’m rarely late. 
      I like ice cream and I really enjoy a nice pair of slacks. 
      Years later, a doctor will tell me I have an IQ of 48 and am what some people call mentally retarded… MAYONAISSE !”*/
    {
        public Forecast GetForecast(string zipcode)
        {
            //new-up a Forecast object called Latest
            Forecast Latest;
            Latest = new Forecast();

            //Call the GetHourlies method which will assemble a list of 36 hourly forecasts into this var hourlies
            var hourlies = GetHourlies(zipcode);
            
            //setup for loop through hourlies...initialize ChanceOfPrecip, HighTemp, and LowTemp to hourlies[0] values, and start hourlies counter at 1 (since we know 0)
            Latest.ChanceOfPrecip = hourlies[0].HourlyChanceOfPrecip;
            Latest.HighTemp = hourlies[0].HourlyTemp;
            Latest.LowTemp = hourlies[0].HourlyTemp;
            int i = 0;

            //loop through hourlies to find max ChanceOfPrecip, HighTemp, and LowTemp
            foreach (Forecast hourly in hourlies)                
            {          
                if (Latest.ChanceOfPrecip >= hourlies[i].HourlyChanceOfPrecip)
                    Latest.ChanceOfPrecip = Latest.ChanceOfPrecip;
                else Latest.ChanceOfPrecip = hourlies[i].HourlyChanceOfPrecip;

                if (Latest.HighTemp >= hourlies[i].HourlyTemp)
                    Latest.HighTemp = Latest.HighTemp;
                else Latest.HighTemp = hourlies[i].HourlyTemp;

                if (Latest.LowTemp <= hourlies[i].HourlyTemp)
                    Latest.LowTemp = Latest.LowTemp;
                else Latest.LowTemp = hourlies[i].HourlyTemp;
                i++;
            }         

            Latest.Timestamp = DateTime.Now;
            Latest.ZipCode = zipcode;
            
            return Latest;
        }
        
        public List<Forecast> GetHourlies(string zipcode)
        {
            //These pull the City and state using the ZipCode
            var ZipCode = zipcode;

            //This bulds the API call using the apiKey and zipcode
            var apiKey = "9a709d3a540125fd";
            var url = @"http://api.wunderground.com/api/{0}/hourly/q/{1}.xml";
            var urlFixed = string.Format(url, apiKey, ZipCode);

            //Calls the API and retrieves the XML file that is parsed.
            var client = new WebClient();
            var response = client.DownloadString(urlFixed);
            var xml = XElement.Parse(response);
            
            //builds forecasts using the parsed XML information
            var hourlyForecasts = (from el in xml.Descendants("forecast")
                select new Forecast
                {
                    HourlyChanceOfPrecip = Convert.ToInt32(el.Descendants("pop").FirstOrDefault().Value),
                    HourlyTemp = Convert.ToInt32(el.Descendants("english").FirstOrDefault().Value)
                }).ToList();
            return hourlyForecasts;            
        }         
        
        //if we wanted to get City, ST from zipcode...
        /*public string[] GetLocation(string zipcode)
        {
            var zipURL = @"http://ziptasticapi.com/{0}";
            var zipURLFixed = string.Format(zipURL,zipcode);
            var zipClient = new WebClient();
            var zipResponse = zipClient.DownloadString(zipURLFixed);

            string[] CityState = {"Greeley", "CO"};

            return CityState;
        }*/
        
    }
}
