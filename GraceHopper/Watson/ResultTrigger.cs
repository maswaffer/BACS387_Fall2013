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
            Playcode = playcode;
            Rockies = new Team();
            Criteria = new List<ICriteria<Play>>();
        }
        private string Playcode { get; set; }
        private List<ICriteria<Play>> Criteria { get; set; }
        private Team Rockies { get; set; }
        public string Message { get; set; }

        private bool match = false;

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            Criteria.Add(criteria as ICriteria<Play>);
        }

        /*public bool CheckCondition()
        {
            var LastPlay = Rockies.GetPlay(


            return match;

        }*/
    }
}
