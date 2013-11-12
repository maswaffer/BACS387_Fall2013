using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ICriteria<T>
    {
        string Name { get; set; }
        bool Check(T value);
        string Message { get; set; }
    }
}
