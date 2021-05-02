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

namespace SquareBoxDependencyProperty
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
      

    }
    public partial class Box : UIElement
    {
        public static readonly DependencyProperty BoxHeightProperty;
        public static readonly DependencyProperty BoxWidthProperty;
        public static readonly DependencyProperty IsSquareProperty;
        static Box()
        {
            FrameworkPropertyMetadata myBoxHeightMetadata = new FrameworkPropertyMetadata(5);
            FrameworkPropertyMetadata myBoxWidthMetadata = new FrameworkPropertyMetadata(5);
            FrameworkPropertyMetadata squareBoxMetadata = new FrameworkPropertyMetadata
            (false, FrameworkPropertyMetadataOptions.None, new
            PropertyChangedCallback(IsSquareBoxTrue), new
            CoerceValueCallback(myBoxHeightWidthSquare));
            BoxHeightProperty = DependencyProperty.Register("BoxHeight", typeof(int), typeof(Box),
            myBoxHeightMetadata, new ValidateValueCallback(IsValidHeight));
            BoxWidthProperty = DependencyProperty.Register("BoxWidth", typeof(int), typeof(Box),
            myBoxWidthMetadata, new ValidateValueCallback(IsValidWidth));
            IsSquareProperty = DependencyProperty.Register("IsSquare", typeof(Boolean),
            typeof(Box), squareBoxMetadata);
        }

        public static void IsSquareBoxTrue(DependencyObject myObject,
DependencyPropertyChangedEventArgs myObjectArgs)
        {
            myObject.CoerceValue(BoxHeightProperty);
            myObject.CoerceValue(BoxWidthProperty);
        }
        public static object myBoxHeightWidthSquare(DependencyObject myObject, object myValue)
        {
            Box box1 = (Box)myObject;
            Boolean square = (Boolean)myValue;
            if (square == true)
                if (box1.BoxHeight > box1.BoxWidth)
                    box1.BoxHeight = box1.BoxWidth;
                else
                    box1.BoxWidth = box1.BoxHeight;
            return true;
        }
        public static Boolean IsValidHeight(object height)
        {
            if ((int)height <= 0)
                return false;
            else
                return true;
        }
        public static Boolean IsValidWidth(object width)
        {
            if ((int)width <= 0)
                return false;
            else
                return true;
        }
        public int BoxHeight
        {
            get
            {
                return (int)GetValue(BoxHeightProperty);
            }
            set
            {
                SetValue(BoxHeightProperty, value);
            }
        }
        public int BoxWidth
        {
            get
            {
                return (int)GetValue(BoxWidthProperty);
            }
            set
            {
                SetValue(BoxWidthProperty, value);
            }
        }
        public Boolean IsSquare
        {
            get
            {
                return (Boolean)GetValue(IsSquareProperty);
            }
            set
            {
                SetValue(IsSquareProperty, value);
            }
        }


    }
}
