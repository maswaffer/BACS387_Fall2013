using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Common;
// trying to using Common 

namespace IfPhotoCondition
{
    class PhotoConditionTrigger : ITrigger
    {
        // constructor photoconditionTrigger
        public PhotoConditionTrigger()
        {
            // come back for more work in here
        }

        // creating a list of icriteria properties to access somewhere else
        private List<ICriteria<Photo>> ListOfCriteria { get; set; }

        // private List<Photo> PhotoSize { get; set; }
        private Flickr Service { get; set; }

        List<ICriteria<Photo>> listOfCriteria = new List<ICriteria<Photo>>();


        // Implement method in ITrigger (MUST)
        public bool CheckCondition()
        {
            // var listOfCriteria = new List<ICriteria<Photo>>();
            listOfCriteria.Add(new SizeTooBig());
            listOfCriteria.Add(new SizeTooSmall());

            // we have to get photo size from flickr service.
            var sizeValue = Service.GetPhoto();
            foreach (var criteria in listOfCriteria)
            {
                // photovalue get from Photo
                criteria.isMet(sizeValue);
            }
            return true;
        }


        // implement the new method from ITrigger 
        public void AddCriteria<T>(ICriteria<T> criteria) where T : new()
        {
            listOfCriteria.Add(criteria as ICriteria<Photo>);
        }


        // implement Message from ITrigger
        public string Message
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
