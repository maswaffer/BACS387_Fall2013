using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStockPrice
{
    public interface ICriteria
    {
        bool Check(Stock value);
        string Message { get; set; }
    }
}
