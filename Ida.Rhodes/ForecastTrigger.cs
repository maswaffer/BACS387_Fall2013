using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public class ForecastTrigger : ITrigger
    {

        public ForecastTrigger(string zipcode)
        {
            Zipcode = zipcode;
            BrickTamland = new TellMeTheForecast();  //“I’m Brick Tamland. When there’s weather to report...I report the weather.”
            CriteriaList = new List<ICriteria<Forecast>>();
        }

        private string Zipcode { get; set; }
        private List<ICriteria<Forecast>> CriteriaList { get; set; }
        private TellMeTheForecast BrickTamland { get; set; }
        public string Message { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            CriteriaList.Add(criteria as ICriteria<Forecast>);
        }        

        public bool CheckCondition()
        {
            StringBuilder CombinedMessage = new StringBuilder(); 
            
            //pulls in the forecast information
            var LatestForecast = BrickTamland.GetForecast(Zipcode);

            //Combines messages if its cold AND there's precip.
            foreach (var criteria in CriteriaList)
            {
                var isMet = criteria.Check(LatestForecast);
                if (isMet)
                {
                    CombinedMessage.Append(criteria.Message);
                }                 
            }
            Message = CombinedMessage.ToString();
            if (Message== "") return false;
                return true;          
        }
    }
}
