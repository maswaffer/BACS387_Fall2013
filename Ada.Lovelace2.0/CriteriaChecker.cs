using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    public class CriteriaChecker
    {
        List<ICriteria> userCriteria = new List<ICriteria>();
        Title uTitle = new Title("Maduro Urges Calm as Venezuelans Jam Stores Again");
        Author uAuthor = new Author("Ricardo Nunes");
        Publisher uPublisher = new Publisher("ABC"); 

        
        //quick google search for "news"
        List<ICriteria> storyCriteria = new List<ICriteria>();
        Title title = new Title("Maduro Urges Calm as Venezuelans Jam Stores Again");
        Author author = new Author("Ricardo Nunes");
        Publisher publisher = new Publisher("ABC");

        bool storyMatch = false; 


        


        public CriteriaChecker()
        {
            storyCriteria.Add(title);
            storyCriteria.Add(author);
            storyCriteria.Add(publisher);

            userCriteria.Add(uTitle);
            userCriteria.Add(uAuthor);
            userCriteria.Add(uPublisher); 
        }

        public void CheckCriteria()
        {
            /* This method can be used to check each story against the criteria list.  */
            throw new NotImplementedException();

            bool match = true;
            string iString = null; 

            if (match == true)
            {
                foreach (Title i in userCriteria)
                {
                    iString = i.ToString();
                    foreach (Title x in storyCriteria)
                    {
                        x.ToString();

                        if (iString.Equals(x))
                        {
                            match = true;
                        }
                        else
                        {
                            match = false;
                        }
                    }
                }
            }

            if (match == true)
            {
                foreach (Author i in userCriteria)
                {
                    iString = i.ToString();
                    foreach (Author x in storyCriteria)
                    {
                        x.ToString();

                        if (iString.Equals(x))
                        {
                            match = true;
                        }
                        else
                        {
                            match = false;
                        }
                    }
                }
            }

            if (match == true)
            {
                foreach (Publisher i in userCriteria)
                {
                    iString = i.ToString();
                    foreach (Publisher x in storyCriteria)
                    {
                        x.ToString();

                        if (iString.Equals(x))
                        {
                            match = true;
                        }
                        else
                        {
                            match = false;
                        }
                    }
                }
            }


            if (match == true)
            {
                storyMatch = true;
            }
            else
            {
                storyMatch = false; 
            }

        }
    }
}
