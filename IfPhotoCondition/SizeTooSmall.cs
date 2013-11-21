using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPhotoCondition
{
    public class SizeTooSmall : ICriteria<Photo>
    {
        public string Message { get; set; }
        public int MinSize { get; set; }
        public string Name
        {
            get { return "Configure Minimum Size"; }
            set { }
        }
        public bool isMet(Photo photoValue)
        {
            /*
             * Check to see if the size of the this photo meets the user input
             * Get the photo first and from there we check photo size
             * if photo size meets the requirement than return true and message
             * else return false
             */
           
            if (photoValue.PhotoSize < MinSize)
            {
                Message = "too small...";       
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }

        // could use delegate ...ask about this...
    }
}
