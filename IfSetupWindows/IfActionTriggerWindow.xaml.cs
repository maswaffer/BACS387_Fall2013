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
using Woot;

namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class IfActionTriggerWindow : IfWindow
    {
        public IfActionTriggerWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var keyword = Keyword.Text;
            //var category = Category.SelectedValue.ToString();

            var criteria = new Criteria();
            criteria.Keyword = keyword;
            //criteria.Category = category;

            //TriggertoProcess = new ActionTrigger();
            //TriggertoProcess.AddCriteria(criteria);

            Close();
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            Keyword.Text = "";
        }

        }
        
    
}
