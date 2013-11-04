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
        public static IfWindow GetTriggerWindow(string selection)
        {
            switch (selection)
            {
                case "Stock Price":
                    return new IfStockPriceWindow();
                default:
                    return null;
            }
        }

        public static List<string> GetTriggerTypes()
        {
            return new List<string>
            {
                "Stock Price"
            };
        }

    }
}
