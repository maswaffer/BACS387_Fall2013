﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using IfPhotoCondition;

namespace ThenShowPhotos
{
    public class ShowPhotosAction:IAction
    {
        public void SendNotification(string message)
        {
            // will delete this line later...
            string dontdothing = "no show message...need window pop to show image";
        }


        public string SizeType
        {
            get;
            set;
        }
        // modify the message depend on what user choose in the combobox...
        public override string ToString()
        {
            var message = string.Format("Show images with size of {0}", SizeType);
            return message;
        }
    }
}
