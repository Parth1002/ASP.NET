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

namespace Navigating_Window
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
            //You need to change the Uri path in this according to the HTML file
			//saved on your computer.
			if ((Boolean)List.IsChecked)
			 myFrame.Navigate(new System.Uri("file:///D:/Black Books/DefinitionList.html"));
			else if ((Boolean)Details.IsChecked)
                myFrame.Navigate(new System.Uri("file:///D:/Black Books/TableColor.html"));

        }
    }
}
