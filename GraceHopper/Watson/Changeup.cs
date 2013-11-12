using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    class Changeup : Pitch
    {
        decimal PitchReleaseTime { get; set; }

        public void TimeHeld()
        {
            throw new NotImplementedException();
        }
    }
}
