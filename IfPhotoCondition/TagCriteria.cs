using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace IfPhotoCondition
{
    public class TagCriteria:ICriteria<Photo>
    {
        public string Name
        {
            get { return "Configure tag"; }
            set{}
        }
        public string userTag { get; set; }
      
        // mosab is working on this need to go back here to modify this...
        public bool Check(Photo photoValue)
        {
            if (!userTag.Equals(photoValue.PhotoTag))
            {
                Message = "not match";
                return true;
            }
            else return false;
        }

        public string Message { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
