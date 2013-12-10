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


namespace ThenShowPhotos
{
    /// <summary>
    /// Interaction logic for IfPokedexWindow.xaml
    /// </summary>
    public partial class IfPokedexWindow : IfWindow
    {
        public IfPokedexWindow()
        {
            InitializeComponent();
            Criteria.Items.Add(new NameMatchCriteria());
            //Criteria.Items.Add(new PokedexNumberMatchCriteria());
            
            CriteriaChosen = new List<ICriteria<Pokedex>>();
            
        }

        private List<ICriteria<Pokedex>> CriteriaChosen { get; set; }


        private void Criteria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            var selection = ((ComboBox)sender).SelectedItem as ICriteria<Pokedex>;
        }

        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var Number = PokemonNumber.Text;
            //var NumberCriteria = new PokedexNumberMatchCriteria();

            var Name = PokemonName.Text;
            var NameCritera = new NameMatchCriteria();
            NameCritera.Name = Name;
            

            TriggertoProcess = new Pokedex();
            
            TriggertoProcess.AddCriteria(NameCritera);
            

            Close();

            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {//closes the window :)
            this.Close();
        }

       
    }
}
