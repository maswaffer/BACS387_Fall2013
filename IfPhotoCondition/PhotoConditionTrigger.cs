using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
// trying to using Common 

namespace IfPhotoCondition
{
    //class PhotoConditionTrigger : ITrigger
    //{
    //    // adding these code @ 9:30 -- 10/31/13
    //    //private Flickr service { get; set; }

    //    // creating a list of icriteria properties to access somewhere else
    //    private List<ICriteria> ListOfCriteria { get; set; }
    //    private List<Photo> PhotoSize { get; set; }
    //    private Flickr Service { get; set; }
        
    //    // Implement method in ITrigger (MUST)
    //    public bool CheckCondition()
    //    {
    //        var listOfCriteria = new List<ICriteria>();
    //        listOfCriteria.Add(new SizeTooBig());
    //        listOfCriteria.Add(new SizeTooSmall());

    //        // we have to get photo size from flickr service.
    //        var sizeValue = Service.GetPhoto();
    //        foreach (var criteria in listOfCriteria)
    //        {
    //            // photovalue get from Photo
    //            criteria.isMet(sizeValue);
    //        }
    //        return true;
    //    }

    //    public string Message
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}
}
