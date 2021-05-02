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

namespace WPFWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowState = WindowState.Maximized;
        }
        private void ChangeLocation_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Normal;
            this.Top = 250;
            this.Left = 250;
        }
        private void AutoFit_Click(object sender, RoutedEventArgs e)
        {
            this.SizeToContent = SizeToContent.Width;
        }
        private void ChangeBorder_Click(object sender, RoutedEventArgs e)
        {
            this.WindowStyle = WindowStyle.ThreeDBorderWindow;
        }
        private void AnotherWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 newwin = new Window1();
            newwin.Show();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

    }
}
