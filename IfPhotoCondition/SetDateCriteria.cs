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
        public DateTime date { get; set; }
        public bool Check(Photo photoValue)
        {
            if (date < photoValue.PhotoDate)
            {
                Message = "will work on the message later....for photo date";
            }
            return true;
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
