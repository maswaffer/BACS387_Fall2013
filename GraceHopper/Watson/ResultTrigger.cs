using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Watson
{
    public class ResultTrigger : ITrigger
    {
        public ResultTrigger(string playcode)
        {
            playcode = "K";
            team = new baseteam("ATL");
            Criteria = new List<ICriteria<Play>>();
        }
        private string playcode { get; set; }
        private List<ICriteria<Play>> Criteria { get; set; }
        private Baseteam Team { get; set; }
        private bool match = false;

        public string Message { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {

            Criteria.Add(criteria as ICriteria<Story>);
        }

        public bool CheckCondition()
        {
            Team.Results = Team.SearchFor(Play);


            return match;

        }
    }
}
