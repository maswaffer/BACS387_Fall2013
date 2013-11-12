using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    public class iCriteria : PitchCount
    {
        bool checkStrikeout (int noBalls, int noStrikes)
        {
            int balls = noBalls;
            int strikes = noStrikes;

            if ((balls + strikes) < 7)
            {
                if (strikes == 3)
                {
                    //fire iTrigger message for strikeout
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        bool checkWalk(int noBalls, int noStrikes)
        {
            int balls = noBalls;
            int strikes = noStrikes;

            if ((balls + strikes) < 7)
            {
                if (balls == 4)
                {
                    //fire iTrigger message for walk
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }


    }
}
