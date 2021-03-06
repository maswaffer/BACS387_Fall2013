﻿using System;
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



namespace ThenShowPhotos
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
        /* Originally intended to use multiple Criteria, but Bing's API did not have the other criteria we developed. */
        private List<ICriteria<Story>> CriteriaSelected {get;set;}
        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            var selection = ((ComboBox)sender).SelectedItem as ICriteria<Story>;

        }
        //Close the window
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Save and send criteria, also close window.
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {                             
            var selected = CriteriaType.SelectedItem as ICriteria<Story>;
            var TitleInfo = new TitleCriteria();
           
            TitleInfo.Keyword = txtKeyword.Text;
            TitleInfo.Date = datStoryDate.SelectedDate.Value;
            CriteriaSelected.Add(selected);

            TriggertoProcess = new StoryTrigger();
            TriggertoProcess.AddCriteria(TitleInfo); 

            Close();
        }
    }
}
