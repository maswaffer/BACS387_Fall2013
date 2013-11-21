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
using IfPhotoCondition;
namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfFlickrWindow.xaml
    /// </summary>
    public partial class IfFlickrWindow : IfWindow
    {
        public IfFlickrWindow()
        {
            InitializeComponent();
            // add more criteria to our combobox
            CriteriaType.Items.Add(new SizeTooBig());
            CriteriaType.Items.Add(new SizeTooSmall());

            CriteriaSelected = new List<ICriteria<Photo>>();
        }

        // this is a list of criteria for the combobox
        private List<ICriteria<Photo>> CriteriaSelected { get; set; }

        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = CriteriaType.SelectedItem as ICriteria<Photo>;
            if (selected is SizeTooBig || selected is SizeTooSmall)
            {
                // disable the parameter for Date
                datePickerBox.IsEnabled = false;
            }
        }

        
    }
}
