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

namespace AddingControls_CodeBehind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label myLabel = new Label();
            myLabel.Content = "Enter your Name:";
            myLabel.FontSize = 12;
            myLabel.FontWeight = FontWeights.Bold;
            myGrid.Children.Add(myLabel);
            TextBox myTextBox = new TextBox();
            myTextBox.Margin = new Thickness(0, 5, 10, 5);
            myTextBox.Height = 30;
            myTextBox.Width = 150;
            myGrid.Children.Add(myTextBox);
            myTextBox.HorizontalAlignment = HorizontalAlignment.Right;
            myTextBox.VerticalAlignment = VerticalAlignment.Top;
            Button myButton = new Button();
            myButton.Content = "Submit";
            myButton.FontSize = 11;
            myButton.FontWeight = FontWeights.Bold;
            myButton.Height = 50;
            myButton.Width = 75;
            myGrid.Children.Add(myButton);
        }
    }
}
