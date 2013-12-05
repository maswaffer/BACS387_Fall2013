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
                var team = new Team();
                var playerList = team.GetPlayers();

                if (PlayerSelected.Text == "Jeff Francis" || PlayerSelected.Text == "Jhoulys Chacin")
                    PitchCriteria.isPitcher = true;

                foreach (Player search in playerList)
                {
                    if (search.Name == PlayerSelected.Text)
                        PitchCriteria.PlayerID = search.playerID;
                }
                
                TriggertoProcess = new ResultTrigger(PitchCriteria.PlayerID);
                TriggertoProcess.AddCriteria(PitchCriteria);
            }

            if (PlaySelected.Text == "Watson.PlayTypeHit")
            {
                var HitCriteria = new PlayTypeHit();
                HitCriteria.Name = PlayerSelected.Text;
                var team = new Team();
                var playerList = team.GetPlayers();

                foreach (Player search in playerList)
                {
                    if (search.Name == PlayerSelected.Text)
                        HitCriteria.PlayerID = search.playerID;
                }

                TriggertoProcess = new ResultTrigger(HitCriteria.PlayerID);
                TriggertoProcess.AddCriteria(HitCriteria);
            }


            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


 
    }
}
