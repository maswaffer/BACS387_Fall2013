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
            if (PlaySelected.Text == "Watson.PlayTypePitch") 
            {
                var PitchCriteria = new PlayTypePitch();
                PitchCriteria.Name = PlayerSelected.Text;
                /*foreach (Player search in Team.roster)
                {
                    if (search.Name = Playerselected.Text)
                        PitchCriteria.PlayerID = search.playerID;
                }*/
                CriteriaSelected.Add(PitchCriteria);
            }

            if (PlaySelected.Text == "Watson.PlayTypeHit")
            {
                var HitCriteria = new PlayTypeHit();
                HitCriteria.Name = PlayerSelected.Text;
                CriteriaSelected.Add(HitCriteria);
            }

            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PlayType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = false;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var b = false;
        }

        

    }
}
