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

namespace CustomGridAttachedProperty
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
        public class myGrid : UIElement
        {
            public static readonly DependencyProperty CellHeightProperty;
            static myGrid()
            {
                CellHeightProperty = DependencyProperty.RegisterAttached("CellHeight",
                typeof(int), typeof(myGrid));
            }
            public static void SetCellHeight(FrameworkElement element, int value)
            {
                element.SetValue(CellHeightProperty, value);
            }
            public static int GetCellHeight(FrameworkElement element)
            {
                return (int)element.GetValue(CellHeightProperty);
            }
        }

    }
}
