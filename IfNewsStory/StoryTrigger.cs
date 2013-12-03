using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing; 

namespace Ada.Lovelace2._0
{
    public class StoryTrigger : ITrigger
    {
        public StoryTrigger(string keyword)
        {
            //Create service
            Keyword = keyword;
            Service = new NewsService("2Q2yOlhzs/CflQI7amq22KrGBgxX3OyQk2mjsYPmZy0");
            Criteria = new List<ICriteria<Story>>();
        }

        private string Keyword { get; set; }
        private List<ICriteria<Story>> Criteria {get;set;}
        private List<Story> searchResults = new List<Story>(); 
        private NewsService Service {get;set;}
        private bool match = false;
        private IEnumerable<NewsResult> BingArticles { get; set; }
        private TitleCriteria title = new TitleCriteria();

        public string Message { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            Criteria.Add(criteria as ICriteria<Story>);
        }

        public bool CheckCondition()
        {
            int size = 0; 
            searchResults = Service.SearchFor(Keyword); 
            while (size <= 10)
            {
                if (title.Check(searchResults[size]) == true)
                {
                    Message = "Here is the link to the article that you requested" + searchResults[size].Link;
                    match = true; 
                }
                else
                {
                    match = false; 
                    size++; 
                }
            }

            return match;
           
        }
         
    }
}
