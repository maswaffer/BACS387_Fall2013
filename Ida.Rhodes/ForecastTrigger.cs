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
            BrickTamland = new TellMeTheForecast();  //“I’m Brick Tamland. When there’s weather to report… I report the weather.”
            CriteriaList = new List<ICriteria<Forecast>>();
        }

        private string Zipcode { get; set; }
        private List<ICriteria<Forecast>> CriteriaList { get; set; }
        private TellMeTheForecast BrickTamland { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            CriteriaList.Add(criteria as ICriteria<Forecast>);
        }

        public string Message { get; set; }

        public bool CheckCondition()
        {
            StringBuilder CombinedMessage = new StringBuilder(); 
            //Thinking we'll use this to combine messages if its cold AND there's precip.
            var LatestForecast = BrickTamland.GetForecast(Zipcode);
            foreach (var criteria in CriteriaList)
            {
                var isMet = criteria.Check(LatestForecast);
                if (isMet)
                {
                    CombinedMessage.Append(criteria.Message);
                    //Message = criteria.Message;
                    //return true;
                }                 
            }
            if (CombinedMessage.ToString() == "") return false;
                return true;
            //return false;
        }

        //do we need this?
        /*public override string ToString()
        {
            var criteriaDescriptions = new List<string>();
            foreach (var c in CriteriaList)
            {
                criteriaDescriptions.Add(c.ToString());
            }

            //make message here.
            return "";
        }*/
    }
}
