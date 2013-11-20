using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Common;

namespace ThenSetupWindows
{
    public class ThenWindow : Window
    {
        public void ProcessAction(Action<IAction> processTheAction)
        {
            ProcessTheAction = processTheAction;
        }

        private Action<IAction> ProcessTheAction { get; set; }
        protected IAction ActionToProcess { get; set; }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            ProcessTheAction(ActionToProcess);
        }
    }
}
