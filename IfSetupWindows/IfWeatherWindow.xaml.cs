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
using Ida.Rhodes;


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
            ZipCode.Focus();
            CriteriaSelected = new List<ICriteria<Forecast>>();
            
        }

        private List<ICriteria<Forecast>> CriteriaSelected { get; set; }

        public string zipCode { get; set; }
        public bool temp { get; set; }
        public string tempAboveOrBelow { get; set; }
        public int userTempValue { get; set; }
        public bool precip { get; set; }
        public int userPrecipValue { get; set; }      
        

        private void SetCriteria(object sender, RoutedEventArgs e)
        {
            zipCode = ZipCode.ToString();
            temp = Convert.ToBoolean(Temp.IsChecked);
            precip = Convert.ToBoolean(Precip.IsChecked);
            userTempValue = Convert.ToInt32(Temp_Select.Value);
            userPrecipValue = Convert.ToInt32(Precip_Select.Value);

            if (Convert.ToBoolean(TempAbove.IsChecked))
                tempAboveOrBelow = "Above";
            else tempAboveOrBelow = "Below";

            if (temp == true);
            {
                var coldCriteria = new ColdCriteria();
                coldCriteria.tempAboveOrBelow = tempAboveOrBelow;
                coldCriteria.userTempValue = userTempValue;
            }

            if (precip == true);
            {
                var rainCriteria = new RainCriteria();
                rainCriteria.userPrecipValue = userPrecipValue;
            }

        }      

        //These enable/disable the Temparature and Precipitation sliders and buttons for better user experience.

        private void Temp_Checked(object sender, RoutedEventArgs e)
        {
            Temp_Select.IsEnabled = true;
            //RelationGrid.IsEnabled = true;
        }

        private void Precip_Checked(object sender, RoutedEventArgs e)
        {
                Precip_Select.IsEnabled = true;
        }    

        private void Temp_Unchecked(object sender, RoutedEventArgs e)
        {
            Temp_Select.IsEnabled = false;
            //RelationGrid.IsEnabled = false;
        }
        
        private void Precip_Unchecked(object sender, RoutedEventArgs e)
        {
            Precip_Select.IsEnabled = false;
        }

        //Closes the window... HAH
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
