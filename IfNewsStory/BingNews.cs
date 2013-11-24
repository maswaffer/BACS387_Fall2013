using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing; 

namespace Ada.Lovelace2._0
{
    public class BingNews
    {

        NewsService news = new NewsService("Bwb3narbj9BNklDtldaerYmHlwlUHswxfVagdbuzBHs");
        List<Story> searchResults = new List<Story>();
        
        
        public void GetStory()
        {
            /*This method will retrieve stories from Google News in order to check them against the criteria */

            //searchResults = (List<NewsResult>)news.SearchFor("null"); 
            
            
        }
    }
}
