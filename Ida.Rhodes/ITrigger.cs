using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ida.Rhodes
{
    public interface ITrigger
    {
        bool CheckCondition();
        string Message { get; set; }
        void AddCriteria<T>(ICriteria<T> criteria) where T : new();
    }
}
