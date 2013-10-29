using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Common
{
    public abstract class TriggerWindow
    {
        private Window Window { get; set; }
        public TriggerWindow(Window window)
        {
            Window = window;
        }

        public abstract ITrigger GetConfiguredTrigger();

        public void Show()
        {
            Window.Show();
        }
    }
}
