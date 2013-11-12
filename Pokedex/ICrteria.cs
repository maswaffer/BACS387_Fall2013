using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICrteria
    {

        /*
         * take a look at stock program
         */
        bool Matches(Pokemon pokmeoncompare);

        string Message { get; set; }
    }
}
