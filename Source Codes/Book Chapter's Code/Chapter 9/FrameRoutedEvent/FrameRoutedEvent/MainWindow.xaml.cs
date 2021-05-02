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

namespace FrameRoutedEvent
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
        public void Frame_MouseHover(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MouseHover event of Frame handled");
        }

    }
    public partial class Frame : Border
    {
        public static readonly RoutedEvent OnMouseHoverEvent; /*declaring the routed event field*/
        static Frame()
        {
            OnMouseHoverEvent = EventManager.RegisterRoutedEvent("OnMouseHover",
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Frame)); /*registering the 
	routed event*/
        }
        public event RoutedEventHandler OnMouseHover /*ClR wrapper for routed event*/
        {
            add
            {
                AddHandler(OnMouseHoverEvent, value);
            }
            remove
            {
                RemoveHandler(OnMouseHoverEvent, value);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(Frame.OnMouseHoverEvent)); /*Raising the routed event*/
        }
    }  

}
