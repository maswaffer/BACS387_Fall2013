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
using IfStockPrice;

namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfStockPriceWindow.xaml
    /// </summary>
    public partial class IfStockPriceWindow : Window, ITriggerWindow
    {

        private ITrigger ConfiguredTrigger { get; set; }

        public IfStockPriceWindow()
        {
            InitializeComponent();

            CriteriaType.Items.Add(new PriceIsHighCriteria());
        }

        public ITrigger GetConfiguredTrigger()
        {
            return ConfiguredTrigger;
        }

        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var symbol = Symbol.Text;

            var selection = ((ComboBox)sender).SelectedItem as ICriteria;
            if (selection is PriceIsHighCriteria)
            {
                //No need to do anything else
            }
            ConfiguredTrigger = new StockPriceTrigger(symbol, selection);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
