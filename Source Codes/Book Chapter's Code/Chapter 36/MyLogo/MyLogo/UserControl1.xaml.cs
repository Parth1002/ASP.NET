using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Security.Principal;

namespace MyLogo
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal winP = (WindowsPrincipal)Thread.CurrentPrincipal;
            WindowsIdentity winI = (WindowsIdentity)winP.Identity;
            if (winI.Name == "Avantika-pc\\TestUser")
                MessageBox.Show("TestUser, you do not have the permissions.The logo will not be visible to you");
            else
                InitializeComponent();
            MessageBox.Show("User Account Details\n\nUser Name: " + winI.Name + "\nAuthentication Type: " + winI.AuthenticationType);
        }
    }
}
