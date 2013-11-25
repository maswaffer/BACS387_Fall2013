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
        public StoryTrigger()
        {
            //Create service
        }

        public bool CheckCondition()
        {
            throw new NotImplementedException();
        }

        public string Message { get; set; }

        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            
            throw new NotImplementedException();
        }

        //specialization
        // Criteria
        // Service

    }
}
