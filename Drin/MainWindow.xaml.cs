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
        }

        private ITrigger TriggerToAdd { get; set; }

        private void AddRule_Click(object sender, RoutedEventArgs e)
        {
            var window = WindowFactory.GetWindow();
            window.Closing += SaveTrigger;
            window.Show();
        }

        private void SaveTrigger(object sender, CancelEventArgs e)
        {
            TriggerToAdd = ((ITriggerWindow)sender).GetConfiguredTrigger();
        }

    }
}
