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
using Common;

namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfStockPriceWindow.xaml
    /// </summary>
    public partial class IfStockPriceWindow : Window, ITriggerWindow
    {

        public IfStockPriceWindow()
        {
            InitializeComponent();
        }

        public ITrigger GetConfiguredTrigger()
        {
            throw new NotImplementedException();
        }
    }
}
