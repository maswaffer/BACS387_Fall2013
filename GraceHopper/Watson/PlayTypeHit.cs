using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    public class PlayTypeHit : ICriteria<Play>
    {
        public string Name
        {
            get { return "Was a run batted in?"; }
            set { }
        }
    }
}
