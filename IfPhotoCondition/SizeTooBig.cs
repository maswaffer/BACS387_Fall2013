using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPhotoCondition
{
    public class SizeTooBig : ICriteria
    {
        public string Message { get; set; }
        public int MaxSize { get; set; }
        public bool isMet(Photo photoValue)
        {

            /*
             * Check to see if the size of the this photo meets the user input
             * Get the photo first and from there we check photo size
             * if photo size meets the requirement than return true and message
             * else return false
             */
            if (photoValue.PhotoSize > MaxSize)
            {
                Message = "Size too big...";
            }
            return false;
        }
    }
}
