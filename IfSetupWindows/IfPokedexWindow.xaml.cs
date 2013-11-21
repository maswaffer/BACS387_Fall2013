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
using Barabara.Liskov;


namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfPokedexWindow.xaml
    /// </summary>
    public partial class IfPokedexWindow : IfWindow
    {
        public IfPokedexWindow()
        {
            InitializeComponent();
            CriteriaChosen = new List<ICriteria<Pokedex>>();
        }

        private List<ICriteria<Pokedex>> CriteriaChosen { get; set; }

        private void AddCriteriaButton_Click(object sender, RoutedEventArgs e)
        {
            //var selected = CriteriaType.SelectedItem as ICriteria<Pokedex>;
            
            //CriteriaChosen.Add(selected);
        }

        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var Number= Numbersomething.Text;
            
            TriggertoProcess = new Pokedex(Number);
            foreach (var c in CriteriaChosen)
            {
                TriggertoProcess.AddCriteria<Pokedex>(c);
            }

            Close();

            
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {//closes the window :)
            this.Close();
        }
    }
}
