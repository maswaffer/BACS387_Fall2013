using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPhotoCondition
{
    public class Photo
    {
        // atrribute for photo size
        private int photoSize;

        public int PhotoSize
        {
            get { return photoSize; }
            set { photoSize = value; }
        }

        // PhotoTag and DateTime attribute
        public List<string> PhotoTag { get; set; }
        public DateTime PhotoDate { get; set; }

        // here the the attribute link so that we can get url from service photo and make that a string 
        public string ImageLink { get; set; }
       


    }
}
