using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Sports
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Nav_Click(object sender, RoutedEventArgs e)
        {
                Button s = sender as Button;
                if (s == this.Previous)
                {
                    if (Show.SelectedIndex == 0)
                    {
                        Show.SelectedIndex = Show.Items.Count - 1;
                    }
                    else
                    {
                        Show.SelectedIndex--;
                    }
                }
                else if (s == this.Next)
                {
                    if (Show.SelectedIndex == Show.Items.Count - 1)
                    {
                        Show.SelectedIndex = 0;
                    }
                    else
                    {
                        Show.SelectedIndex++;
                    }
                }
                Show.ScrollIntoView(Show.SelectedItem);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 5000); // 5000 Milliseconds 
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }

        public void Each_Tick(object o, EventArgs sender)
        {
            if (Show.SelectedIndex == Show.Items.Count - 1)
            {
                Show.SelectedIndex = 0;
            }
            else
            {
                Show.SelectedIndex++;
            }
            Show.ScrollIntoView(Show.SelectedItem);
        }
    }
}
