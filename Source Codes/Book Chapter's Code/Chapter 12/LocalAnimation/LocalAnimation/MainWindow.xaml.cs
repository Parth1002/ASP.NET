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
using System.Windows.Media.Animation;

namespace LocalAnimation
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
            DoubleAnimation rect = new DoubleAnimation();
            rect.From = 0;
            rect.To = 360;
            rect.Duration = new Duration(TimeSpan.FromSeconds(7));
            RotateTransform rotate = new RotateTransform();
            rectangle1.RenderTransform = rotate;
            rotate.BeginAnimation(RotateTransform.AngleProperty, rect);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation rect = new DoubleAnimation();
            rect.From = 0;
            rect.To = 360;
            rect.Duration = new Duration(TimeSpan.FromSeconds(7));
            rect.RepeatBehavior = RepeatBehavior.Forever;
            RotateTransform rotate = new RotateTransform();
            rectangle1.RenderTransform = rotate;
            rotate.BeginAnimation(RotateTransform.AngleProperty, rect);

        }
    }
}
