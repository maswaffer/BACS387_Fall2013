using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfWeatherWindow.xaml
    /// </summary>
    public partial class IfWeatherWindow : IfWindow
    {
        public IfWeatherWindow()
        {
            InitializeComponent();
        }

        public int zipCode { get; set; }
        public bool temp { get; set; }
        public string tempAboveOrBelow { get; set; }
        public int tempValue { get; set; }
        public bool precip { get; set; }
        public int precipValue { get; set; }      


        private void SetCriteria(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
