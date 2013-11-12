using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ITrigger
    {
        string Message { get; set; }

        bool Check();
       

        
        
    }
}
