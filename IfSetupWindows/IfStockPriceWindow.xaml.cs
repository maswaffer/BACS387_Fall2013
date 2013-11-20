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
    public partial class IfStockPriceWindow : IfWindow
    {


        public IfStockPriceWindow()
        {
            InitializeComponent();

            CriteriaType.Items.Add(new PriceIsHighCriteria());
            CriteriaType.Items.Add(new PriceChangeGreaterThan());
            
            CriteriaSelected = new List<ICriteria<Stock>>();
            HideParameterSections();
        }

        private List<ICriteria<Stock>> CriteriaSelected { get; set; }

        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HideParameterSections();

            //Show only the right parameters boxes
            var selection = ((ComboBox)sender).SelectedItem as ICriteria<Stock>;
            if (selection is PriceIsHighCriteria)
            {
                //No need to do anything else, this ICriteria needs no parameters
            }
            else if (selection is PriceChangeGreaterThan)
            {
                Parameters.Visibility = System.Windows.Visibility.Visible;
                PercentChangeParams.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void HideParameterSections()
        {
            //Hide everything related to parameters
            //We only have the label and one parameter so far
            Parameters.Visibility = System.Windows.Visibility.Hidden;
            PercentChangeParams.Visibility = System.Windows.Visibility.Hidden;
        }

        private void AddCriteriaButton_Click(object sender, RoutedEventArgs e)
        {
            var selected = CriteriaType.SelectedItem as ICriteria<Stock>;
            if (selected is PriceChangeGreaterThan)
            {
                var percent = PercentChange.Text.Replace("%", "");
                ((PriceChangeGreaterThan)selected).PercentChange = Convert.ToDecimal(percent);
            }
            CriteriaSelected.Add(selected);
            HideParameterSections();
            CriteriaType.SelectedIndex = -1;

            ConfiguredCriteria.Children.Add(new TextBlock { Text = selected.ToString() });
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var symbol = Symbol.Text;

            TriggertoProcess = new StockPriceTrigger(symbol);
            foreach (var c in CriteriaSelected)
            {
                TriggertoProcess.AddCriteria<Stock>(c);
            }

            Close();
        }
    }
}
