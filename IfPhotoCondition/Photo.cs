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

       // communicate with Flickr
        public void goToFlickr()
        {
            throw new NotImplementedException();
        }


    }
}
