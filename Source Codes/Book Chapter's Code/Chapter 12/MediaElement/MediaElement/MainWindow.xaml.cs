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

namespace MediaElement
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Position = TimeSpan.Zero;
            mediaElement1.Play();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
            mediaElement1.Position = TimeSpan.FromSeconds(slider1.Value);

        }

        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = (double)slider1.Value;
        }

        private void ChangeMediaSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.SpeedRatio = (double)slider2.Value;
        }
    }
}
