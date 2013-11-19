using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    public class GetCriteria : ICriteria
    {  
        List<ICriteria> searchCriteria = new List<ICriteria>();
        string input = ""; 

        
        public List<ICriteria> getSearchCriteria()
        {
            //This method will allow the user to enter their given Criteria
            Console.WriteLine("You can choose multiple criteria to monitor, to shrink down results.  When prompted with a search option press 'y' to search by that method, or 'n' to move to the next method");
            string check = Console.ReadLine();

            Console.WriteLine("Search by Title: ");
            check = Console.ReadLine();
            if (check.Equals("y"))
            {
                input = Console.ReadLine();
                Title title = new Title(input); 
                searchCriteria.Add(title); 
            }
             
            Console.WriteLine("Search by Author: ");
            check = Console.ReadLine();
            if (check.Equals("y"))
            {
                input = Console.ReadLine();
                Author author = new Author(input);
                searchCriteria.Add(author); 
            }
            
            bool keyDone = false;
            Console.WriteLine("Search by Keyword: ");
            check = Console.ReadLine();
            if (check.Equals("y"))
            {
                while (keyDone == false)
                {
                    {
                        input = Console.ReadLine();
                        Keyword keyword = new Keyword(input);
                        searchCriteria.Add(keyword);
                    }
                    Console.WriteLine("Add another keyword? ");
                    check = Console.ReadLine();
                    if (check.Equals("y"))
                    {
                        keyDone = false;
                    }
                    else
                    {
                        keyDone = true;
                    }
                }
            }

            Console.WriteLine("Search by Publisher: ");
            check = Console.ReadLine();
            if (check.Equals("y"))
            {
                input = Console.ReadLine();
                Publisher publisher = new Publisher(input);
                searchCriteria.Add(publisher);
            }

            return searchCriteria; 
        }
    }
}
