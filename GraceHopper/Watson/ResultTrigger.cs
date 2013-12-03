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
        /*public ResultTrigger(string playcode)
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

        //Rylee's Code
        public ResultTrigger(string player)
        {
            PlayerID = player;
            Tulo = new PlaysForPlayer();
            Criteria = new List<ICriteria<Play>>();
        }

        private string PlayerID { get; set; }
        private List<ICriteria<Play>> Criteria { get; set; }
        private PlaysForPlayer Tulo { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            Criteria.Add(criteria as ICriteria<Play>);
        }

        public string Message { get; set; }

        public bool CheckCondition()
        {
            /*var LastPlay = Tulo.GetPlay(PlayerID);

            foreach (var criteria in Criteria)
            {
                var isPlay = criteria.Check(LastPlay);
                if (isPlay) 
                {
                    Message = criteria.Message;
                    return true;
                }
            }*/
            return false;
        }




    }
}
