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

namespace Storyboard_MediaPlayback
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Element_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider1.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

       

        private void MediaTimeChanged(object sender, EventArgs e)
        {
            slider1.Value = mediaElement1.Position.TotalMilliseconds;
        }
    }
}
