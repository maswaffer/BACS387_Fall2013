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
                case "Weather":
                    return new IfWeatherWindow();
                case "Pokedex":
                    return new IfPokedexWindow();
                case "Flickr":
                    return new IfFlickrWindow();
                case "News":
                    return new IfStoryWindow();
                case "Woot":
                    return new IfActionTriggerWindow();
                case "Pitch":
                    return new IfPitch();
                            
                default:
                    return null;
            }
        }

        public static List<string> GetTriggerTypes()
        {
            return new List<string>
            {
                "Stock Price",
                "Weather",
                "Pokedex",
                "Flickr",
                "News",
                "Pitch",
                "Woot"
            };
        }

    }
}
