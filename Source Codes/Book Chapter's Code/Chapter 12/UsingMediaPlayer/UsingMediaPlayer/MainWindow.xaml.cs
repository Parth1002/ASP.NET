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

namespace UsingMediaPlayer
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

            MediaTimeline myTime = new MediaTimeline(new
        Uri(@"D:\wmafiles\Ringtone 01.wma",
        UriKind.Relative));
            myTime.RepeatBehavior = RepeatBehavior.Forever;

            MediaClock myClock = myTime.CreateClock();

            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Clock = myClock;
            VideoDrawing myDrawing = new VideoDrawing();
            myDrawing.Rect = new Rect(0, 0, 100, 100);
            myDrawing.Player = myPlayer;

        }
    }
}
