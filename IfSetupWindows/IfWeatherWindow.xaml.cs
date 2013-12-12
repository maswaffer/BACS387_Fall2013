using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
using System.Xml.Linq;
using System.IO;

namespace ThenShowPhotos
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

        public bool tempChecked { get; set; }
        public string tempAboveOrBelow { get; set; }
        public bool precipChecked { get; set; }                   

        private void SetCriteria(object sender, RoutedEventArgs e)
        {
            //This builds the API call using the apiKey and zipcode
            var apikey = "9a709d3a540125fd";
            var url = @"http://api.wunderground.com/api/{0}/hourly/q/{1}.xml";
            var urlfixed = string.Format(url, apikey, ZipCode);

            //calls the api and retrieves the xml file that is parsed.
            var client = new WebClient();
            var response = client.DownloadString(urlfixed);
            var xml = XElement.Parse(response);

            //pulls in the xml information for zipcode validity check
            if (Convert.ToString(xml.Descendants("error").FirstOrDefault().Value) != null)
            {
                MessageBox.Show("Son of a bee-sting. That zipcode is not found. Try Again.");
                ZipCode.Focus();
            }

            else
            {
                CriteriaSelected.Clear();
                tempChecked = Convert.ToBoolean(Temp.IsChecked);
                precipChecked = Convert.ToBoolean(Precip.IsChecked);

                if (Convert.ToBoolean(TempAbove.IsChecked))
                    tempAboveOrBelow = "Above";
                else tempAboveOrBelow = "Below";

                if (tempChecked == true)
                {
                    var tempCriteria = new TempCriteria();
                    tempCriteria.tempAboveOrBelow = tempAboveOrBelow;
                    tempCriteria.userTempValue = Convert.ToInt32(Temp_Select.Value);
                    CriteriaSelected.Add(tempCriteria);
                }

                if (precipChecked == true)
                {
                    var rainCriteria = new RainCriteria();
                    rainCriteria.userPrecipValue = Convert.ToInt32(Precip_Select.Value);
                    CriteriaSelected.Add(rainCriteria);
                }

                TriggertoProcess = new ForecastTrigger(ZipCode.ToString());
                foreach (var c in CriteriaSelected)
                {
                    TriggertoProcess.AddCriteria<Forecast>(c);
                }

                MessageBox.Show("Your settings have been saved.");
            }
        }      

        //These enable/disable the Temparature and Precipitation sliders and buttons for better user experience.

        private void Temp_Checked(object sender, RoutedEventArgs e)
        {
            Temp_Select.IsEnabled = true;
            RelationGrid.IsEnabled = true;
        }

        private void Precip_Checked(object sender, RoutedEventArgs e)
        {
                Precip_Select.IsEnabled = true;
        }    

        private void Temp_Unchecked(object sender, RoutedEventArgs e)
        {
            Temp_Select.IsEnabled = false;
            RelationGrid.IsEnabled = false;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
