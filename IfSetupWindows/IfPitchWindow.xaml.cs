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
using Watson;

namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfPitch.xaml
    /// </summary>
    public partial class IfPitch : IfWindow
    {
        public IfPitch()
        {
            InitializeComponent();
            PlaySelected.Items.Add(new PlayTypePitch());
            PlaySelected.Items.Add(new PlayTypeHit());
            CriteriaSelected = new List<ICriteria<Play>>();  
        }

       
        private List<ICriteria<Play>> CriteriaSelected { get; set; }

        private void acptBtn_Click(object sender, RoutedEventArgs e)
        {
            //var team = TeamSelect.Text;
           // TriggertoProcess = new BaseballCriteriaTrigger();
            //  TriggertoProcess.AddCriteria<Play>(c);


            //Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PlayType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        

    }
}
