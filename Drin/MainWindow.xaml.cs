using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common;
using Drin.Engine;

namespace Drin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TriggerTypes.ItemsSource = WindowFactory.GetTriggerTypes();
            ActionTypes.ItemsSource = WindowFactory.GetActionTypes();
            Tank = new Tank();
            Motor = new Motor();
            Motor.Tank = Tank;

            Motor.CheckingRule += (t) =>
            {
                Dispatcher.Invoke(() =>
                {
                    ProgressReport.Children.Add(new TextBlock { Text = t });
                });
            };

            Motor.NotificationSent += (t) =>
            {
                Dispatcher.Invoke(() =>
                {
                    ProgressReport.Children.Add(new TextBlock { Text = t });
                }
            };

            Motor.StatusUpdate += (t) =>
            {
                //TODO: Finish this
            };
              
        }

        private ITrigger TriggerToAdd { get; set; }
        private IAction ActionToAdd { get; set; }
        private Tank Tank { get; set; }
        private Motor Motor { get; set; }

        private void ConfigureTrigger_Click(object sender, RoutedEventArgs e)
        {
            var triggerType = TriggerTypes.SelectedItem.ToString();
            var window = WindowFactory.GetTriggerWindow(triggerType);
            window.ProcessTrigger((t) =>
            {
                TriggerToAdd = t;
            });
            window.Show();
        }

        private void ConfigureAction_Click(object sender, RoutedEventArgs e)
        {
            var actionType = ActionTypes.SelectedItem.ToString();
            var window = WindowFactory.GetActionWindow(actionType);
            window.ProcessAction((t) =>
            {
                ActionToAdd = t;
            });
            window.Show();
        }

        private void AddRule_Click(object sender, RoutedEventArgs e)
        {
            var rule = new Rule(TriggerToAdd, ActionToAdd);
            AddedRules.Children.Add(new TextBlock { Text = rule.ToString() });
            Tank.Fill(rule);
        }

        private void StartEngine_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(Motor.Start);
        }


    }
}
