using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class ForecastTrigger : ITrigger
    {

        public ForecastTrigger(int zipcode)
        {
            Zipcode = zipcode;
            Service = new WeatherService();
            Criteria = new List<ICriteria<Forecast>>();
        }

        private int Zipcode { get; set; }
        private List<ICriteria<Forecast>> Criteria { get; set; }
        private WeatherService Service { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            Criteria.Add(criteria as ICriteria<Forecast>);
        }

        public string Message { get; set; }

        public bool CheckCondition()
        {
            var condition = Service.GetForecast(Zipcode);
            foreach (var criteria in Criteria)
            {
                var isMet = criteria.Check(condition);
                if (isMet)
                {
                    Message = criteria.Message;
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            var criteriaDescriptions = new List<string>();
            foreach (var c in Criteria)
            {
                criteriaDescriptions.Add(c.ToString());
            }

            //make message here.
            return "";
        }
    }
}
