﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    public class PlayTypePitch : ICriteria<Play>
    {
        public string Pitcher
        {
            get { return "Was a play made by the Pitcher?"; }
            set { }
        }

        public string Message { get; set; }
        public string Name { get; set; }
        public string PlayerID { get; set; }
        public bool isPitcher { get; set; }

        public bool Check(Play Player)
        {
            if (isPitcher == true)
            {
                if (Player.PlayCode.Contains('K'))
                {
                    Message = ("The Pitcher has recorded a strikeout");
                    return true;
                }
                else if (Player.PlayCode.Contains('W'))
                {
                    Message = ("The Pitcher has recorded a walk");
                    return true;
                }
                else
                    return false;
            }
            else
            {
                Message = ("Player did not pitch this season!");
                return true;
            }


        }
    }
}
