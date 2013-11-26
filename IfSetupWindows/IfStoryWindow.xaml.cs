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
using Ada.Lovelace2._0;



namespace IfSetupWindows
{
    /// <summary>
    /// Interaction logic for IfStoryWindow.xaml
    /// </summary>
    public partial class IfStoryWindow : IfWindow
    {
        public IfStoryWindow()
        {
            InitializeComponent();
            CriteriaType.Items.Add(new TitleCriteria());
            

            CriteriaSelected = new List<ICriteria<Story>>();
        }

        private List<ICriteria<Story>> CriteriaSelected {get;set;}
        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            var selection = ((ComboBox)sender).SelectedItem as ICriteria<Story>;

        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {         
                        
            var selected = CriteriaType.SelectedItem as ICriteria<Story>;
            var keyword = txtKeyword.Text;
            var storyDate = datStoryDate;

            CriteriaSelected.Add(selected);
            CriteriaType.SelectedIndex = -1;
            TriggertoProcess = new StoryTrigger(keyword);
            foreach (var c in CriteriaSelected)
            {
                TriggertoProcess.AddCriteria<Story>(c);
            }
             
 
            Close();
        }
    }
}
