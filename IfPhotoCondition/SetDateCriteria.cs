using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace IfPhotoCondition
{
    public class SetDateCriteria:ICriteria<Photo>
    {
        public string Name
        {
            get { return "Configure Date"; }
            set { }
        }
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
