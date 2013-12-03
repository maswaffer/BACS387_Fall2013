using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace IfPhotoCondition
{
    public class TagNotMatch : ICriteria<Photo>
    {
        public string Tag { get; set; }
        public bool Check(Photo photoValue)
        {
            if (photoValue.PhotoTag.Equals(Tag))

            { Message = "Tag not Match"; }
            return true; 
        }

        public string Name { get { return "Configure Tag"; } set { } }
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
