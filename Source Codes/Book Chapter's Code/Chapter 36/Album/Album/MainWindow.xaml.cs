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
using System.Security.Permissions;

namespace Album
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 win;
        public MainWindow()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal winP = (WindowsPrincipal)Thread.CurrentPrincipal;          
        }
        private void EditImage_Click(object sender, RoutedEventArgs e)
        {
            PrincipalPermission editPermission = new PrincipalPermission("Avantika-pc\\Avantika", "BUILTIN\\Administrators");
            try
            {
                editPermission.Demand(); //demanding an impertaive security check
                win = new Window1();
                int selectedImage = list1.SelectedIndex;
                switch (selectedImage)
                {
                    case 0: win.showImage.Source = img1.Source; break;
                    case 1: win.showImage.Source = img2.Source; break;
                    case 2: win.showImage.Source = img3.Source; break;
                    case 3: win.showImage.Source = img4.Source; break;
                    case 4: win.showImage.Source = img5.Source; break;
                }
                win.Show();
                this.Hide();
            }
            catch      //executes for unauthorized users
            {
                MessageBox.Show("You are not authorized to preview!", "Warning");
            }
        }
        private void Img_Select(object sender, RoutedEventArgs e)
        {
            this.EditImage.IsEnabled = true;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
