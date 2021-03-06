﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ITrigger
    {
        bool CheckCondition();
        string Message { get; set; }
        void AddCriteria<T>(ICriteria<T> criteria) where T: new();
    }
}
