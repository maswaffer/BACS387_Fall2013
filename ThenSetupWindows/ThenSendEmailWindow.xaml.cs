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
using ThenSendEmail;

namespace ThenSetupWindows
{
    /// <summary>
    /// Interaction logic for ThenSendEmailWindow.xaml
    /// </summary>
    public partial class ThenSendEmailWindow : ThenWindow
    {
        public ThenSendEmailWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            var emailAction = new EmailAction();
            emailAction.Recipient = Email.Text;
            ActionToProcess = emailAction;
            Close();
        }
    }
}
