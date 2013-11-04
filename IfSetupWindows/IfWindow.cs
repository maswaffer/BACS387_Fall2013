using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Common;

namespace IfSetupWindows
{
    public class IfWindow : Window
    {
        public void ProcessTrigger(Action<ITrigger> processTrigger)
        {
            ProcessTheTrigger = processTrigger;
        }

        private Action<ITrigger> ProcessTheTrigger { get; set; }
        protected ITrigger TriggertoProcess { get; set; }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            ProcessTheTrigger(TriggertoProcess);
        }
    }
}
