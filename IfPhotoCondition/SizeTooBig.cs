using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace IfPhotoCondition
{
    public class SizeTooBig : ICriteria<Photo>
    {
        public string Message { get; set; }
        public int MaxSize { get; set; }

        public string Name { get{ return "Configure Maximum Size";} set{} }


        public bool Check(Photo photoValue)
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

        // to change the name in the combobox
        public override string ToString()
        {
            return Name;
        }
        
    }
}
