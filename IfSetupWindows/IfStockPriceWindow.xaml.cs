﻿using System;
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
        }

        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var symbol = Symbol.Text;

            var selection = ((ComboBox)sender).SelectedItem as ICriteria<Stock>;
            if (selection is PriceIsHighCriteria)
            {
                //No need to do anything else
            }
            TriggertoProcess = new StockPriceTrigger(symbol);
            TriggertoProcess.AddCriteria<Stock>(selection);

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
