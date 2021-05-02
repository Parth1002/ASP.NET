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


namespace Storyboard_Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NameScope.SetNameScope(this, new NameScope());
            this.RegisterName(button1.Name, button1);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation myAnimation = new DoubleAnimation();
            myAnimation.From = 100;
            myAnimation.To = 300;
            myAnimation.AutoReverse = true;
            myAnimation.RepeatBehavior = RepeatBehavior.Forever;
            myAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));

            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myAnimation);
            Storyboard.SetTargetName(myAnimation, button1.Name);
            Storyboard.SetTargetProperty(myAnimation, new
           PropertyPath(Button.WidthProperty));

            myStoryboard.Begin(this);

        }
    }
}
