﻿using System;
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

        // 
        public string PhotoTag { get; set; }
        public DateTime PhotoDate { get; set; }
       // communicate with Flickr
        public void goToFlickr()
        {
            throw new NotImplementedException();
        }


    }
}
