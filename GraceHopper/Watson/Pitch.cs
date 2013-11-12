using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    public class Pitch
    {
        decimal PitchSpeed { get; set; }
        decimal PitchAccuracy { get; set; }
        decimal PitchCurve { get; set; }
        string PitchHand { get; set; }
        string PitchGrip { get; set; }
        string ballOrStrike { get; set; }
    }
}
