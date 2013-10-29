using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Common;
using IfSetupWindows;

namespace Drin
{
    public static class WindowFactory
    {
        public static Window GetWindow()
        {
            return new IfStockPriceWindow();
        }
    }
}
