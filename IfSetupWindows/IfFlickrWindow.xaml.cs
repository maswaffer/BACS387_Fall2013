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
using IfPhotoCondition; 
using Common;


namespace ThenShowPhotos
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
            CriteriaType.Items.Add(new SetDateCriteria());
            CriteriaType.Items.Add(new TagCriteria());

            CriteriaSelected = new List<ICriteria<Photo>>();
        }

        // this is a list of criteria for the combobox
        private List<ICriteria<Photo>> CriteriaSelected { get; set; }

        // Notify that item in comboBox is selected or change
        // so we know which parameter to disable and to enable
        private void CriteriaType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = CriteriaType.SelectedItem as ICriteria<Photo>;
            if (selected is SizeTooBig || selected is SizeTooSmall)
            {
                // disable the parameter for Date
                datePickerBox.IsEnabled = false;
                txtEnterSize.IsEnabled = true;
                TagTextBox.IsEnabled = false;
            }
            else if (selected is SetDateCriteria)
            {
                //disable the parameter for Size
                txtEnterSize.IsEnabled = false;
                datePickerBox.IsEnabled = true;
                TagTextBox.IsEnabled = false;
            }
            else
            {
                TagTextBox.IsEnabled = true;
                txtEnterSize.IsEnabled = false;
                datePickerBox.IsEnabled = false;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // Clear everything
            txtEnterSize.Text = "";
            datePickerBox.Text = "";
            CriteriaType.Text = "";
            TagTextBox.Text = "";
        }

        // when user hit the Add Criteria Button...
        private void AddCriteria_Click(object sender, RoutedEventArgs e)
        {
            // validation the text from Enter width of the photo
            // come back to this later...
            var selected = CriteriaType.SelectedItem as ICriteria<Photo>;
            if (selected is SizeTooBig || selected is SizeTooSmall)
            {
                var input = txtEnterSize.Text;
                int output;
                bool dataCheck = Int32.TryParse(input, out output);

                // condition to check if the user enter correct data type for photo width   
                    if (dataCheck == false)
                    {
                        MessageBox.Show("Wrong type, should be number");
                        txtEnterSize.Text = "";
                        txtEnterSize.Focus();     
                    }
                    else if (dataCheck == true)
                    {
                        AddCriteria(selected);
                        
                    }
            }
            else
            {
                // Calling helper method to perform add criteria and 
                // Show Message to let the user know that criteria is added ok
                AddCriteria(selected);
            }
            
        }

        // Method use for adding criteria.
        private void AddCriteria(ICriteria<Photo> selected)
        {
            var _selected = CriteriaType.SelectedItem as ICriteria<Photo>;
            CriteriaSelected.Add(_selected);
            MessageBox.Show("Sucessfully added");
        }
        // save information to the List and close the form
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // errors here need ask...
            TriggertoProcess = new PhotoConditionTrigger();
            foreach (var c in CriteriaSelected)
            {
                TriggertoProcess.AddCriteria<Photo>(c);
            }
            MessageBox.Show("you are saving now...");
            
            Close();
        }
        //clears the inputs when you hit the combobox "Dropdown menu"
        private void ClearEntryWhenChange(object sender, EventArgs e)
        {
            txtEnterSize.Text = "";
            TagTextBox.Text = "";
            datePickerBox.Text = "";
        }

        

        
    }
}
