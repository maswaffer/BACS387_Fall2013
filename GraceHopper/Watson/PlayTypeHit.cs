using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Watson
{
    public class PlayTypeHit : ICriteria<Play>
    {
        public string Offense 
        { 
            get { return "Was a play made by the Hitter?"; }
            set { }
        }

        public string Message { get; set; }
        public string Name { get; set; }

        public bool Check(Play Player)
        {
            if (Player.PlayCode.Contains('S'))
            {
                Message = ("The Hitter has recorded a Single");
                return true;
            }
            else if (Player.PlayCode.Contains('D'))
            {
                Message = ("The Hitter has recorded a Double");
                return true;
            }
            else if (Player.PlayCode.Contains('T'))
            {
                Message = ("The Hitter has recorded a Triple");
                return true;
            }
            else if (Player.PlayCode.Contains('H'))
            {
                Message = ("The Hitter has recorded a HomeRun!");
                return true;
            }
            else
                return false;
        }

    }
    
}
