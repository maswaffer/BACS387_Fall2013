﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
// trying to using Common 

namespace IfPhotoCondition
{
    public class PhotoConditionTrigger : ITrigger
    {
        // constructor photoconditionTrigger
        public PhotoConditionTrigger()
        {
            // come back for more work in here
            Service = new Flickr();
            Criteria = new List<ICriteria<Photo>>();
        }

        private List<ICriteria<Photo>> Criteria { get; set; }

        // creating a list of icriteria properties to access somewhere else
        private List<ICriteria<Photo>> ListOfCriteria { get; set; }

        // private List<Photo> PhotoSize { get; set; }
        private Flickr Service { get; set; }

        List<ICriteria<Photo>> listOfCriteria = new List<ICriteria<Photo>>();


        // Implement method in ITrigger (MUST)
        public bool CheckCondition()
        {
            // var listOfCriteria = new List<ICriteria<Photo>>();
            // we could do a for loop here instead
            listOfCriteria.Add(new SizeTooBig());
            listOfCriteria.Add(new SizeTooSmall());

            // we have to get photo size from flickr service.
            var Value = Service.GetPhotosByArea();
            bool result;
            foreach (var criteria in listOfCriteria)
            {
                // photovalue get from Photo
                result = criteria.Check(Value);
                
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
        { get; set; }
    }
}
