﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.Lovelace2._0
{
    class Publisher : ICriteria 
    {
        public string publisher { get; set; }


        public Publisher(string publisherInput)
        {
            publisher = publisherInput; 
        }
    }
}
