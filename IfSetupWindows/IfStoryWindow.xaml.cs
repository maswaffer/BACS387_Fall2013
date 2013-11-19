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
using IfNewsStory;

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

            CriteriaSelected = new List<ICriteria<Story>>();
        }

        private List<ICriteria<Story>> CriteriaSelected {get;set;}


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var keyword = Keyword.Text;
            var author = Author.Text;
            var title = Title.Text;


            /*TriggertoProcess = new NewsStoryTrigger();
            foreach (var c in CriteriaSelected)
            {
                TriggertoProcess.AddCriteria<Story>(c);
            }
            */
            Close();
        }
    }
}
