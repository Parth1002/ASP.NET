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
using System.Printing;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using System.IO;


namespace PrintingDocument
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

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            XpsDocument myXPSDocument = new XpsDocument("../../Penguin.xps",
             FileAccess.Read);
            FixedDocumentSequence myXPSDocumentSeq =
             myXPSDocument.GetFixedDocumentSequence();
            DocumentPaginator XPSpaginator = myXPSDocumentSeq.DocumentPaginator;
            PrintDialog myPrintDialog = new PrintDialog();
            Boolean printResult = (Boolean)myPrintDialog.ShowDialog();
            if (printResult == true)
            {
                myPrintDialog.PrintDocument(XPSpaginator, "XPS Document Printing");
                MessageBox.Show("printing in process...");
            }       

        }
    }
}
