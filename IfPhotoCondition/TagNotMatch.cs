using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace IfPhotoCondition
{
    class TagNotMatch : ICriteria<Photo>
    {
        public bool Check(Photo photoValue)
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
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
