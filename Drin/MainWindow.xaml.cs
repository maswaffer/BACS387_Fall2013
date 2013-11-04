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
            Tank = new Tank();
        }

        private ITrigger TriggerToAdd { get; set; }
        private IAction ActionToAdd { get; set; }
        private Tank Tank { get; set; }

        private void AddTrigger_Click(object sender, RoutedEventArgs e)
        {
            var triggerType = TriggerTypes.SelectedItem.ToString();
            var window = WindowFactory.GetTriggerWindow(triggerType);
            window.ProcessTrigger((t) =>
            {
                TriggerToAdd = t;
            });
            window.Show();
        }

        private void AddAction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddRule_Click(object sender, RoutedEventArgs e)
        {
            var rule = new Rule(TriggerToAdd, ActionToAdd);
            Tank.Fill(rule);
        }


    }
}
