using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    public class StoryTrigger : ITrigger
    {
        public StoryTrigger(string keyword)
        {
            //Create service
            Keyword = keyword;
            //Service = new NewsService();
            Criteria = new List<ICriteria<Story>>();

             
        }
        private string Keyword { get; set; }
        private List<ICriteria<Story>> Criteria {get;set;}
        private NewsService Service {get;set;}



        public string Message { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {

            Criteria.Add(criteria as ICriteria<Story>);
        }

        

        public bool CheckCondition()
        {
            

            return false;
           
        }
         

        //specialization
        // Criteria
        // Service

    }
}
