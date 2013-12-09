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
        // mosab is working on this need to go back here to modify this...
        public bool Check(Photo photoValue)
        {
            throw new NotImplementedException();
        }

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

        public override string ToString()
        {
            return Name;
        }
    }
}
