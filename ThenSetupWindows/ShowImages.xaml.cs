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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThenShowPhotos;

namespace ThenSetupWindows
{
    /// <summary>
    /// Interaction logic for ShowImages.xaml
    /// </summary>
    public partial class ShowImages : ThenWindow
    {
        public ShowImages()
        {
            InitializeComponent();
            ListOfSize.Items.Add("150 pixels Square"); // will alter string with photo URL type source
            ListOfSize.Items.Add("500 pixels"); // will alter string with photo URL type source
            ListOfSize.Items.Add("800 pixels"); // will alter string with photo URL type source
            ListOfSize.Items.Add("1600 pixels"); // will alter string with photo URL type source     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var showPhotoAction = new ShowPhotosAction();
            showPhotoAction.sizeType = ListOfSize.Text;
            ActionToProcess = showPhotoAction;
            Close();
        }


    }
}
