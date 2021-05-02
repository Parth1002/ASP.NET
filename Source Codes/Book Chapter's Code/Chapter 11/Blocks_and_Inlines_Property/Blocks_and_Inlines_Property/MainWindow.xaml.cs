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

namespace Blocks_and_Inlines_Property
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Run First = new Run();
            First.Text = "Hello!  ";
            Bold bold = new Bold();
            Run runBold = new Run();
            runBold.Text = "Blocks and Inlines  ";
            bold.Inlines.Add(runBold);
            Run Last = new Run();
            Last.Text = " text in WPF.";
            Hyperlink hyperlink = new Hyperlink();
            Run runHyprelink = new Run();
            runHyprelink.Text = " This is a Hyperlink.";
            hyperlink.Inlines.Add(runHyprelink);
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(First);
            paragraph.Inlines.Add(bold);
            paragraph.Inlines.Add(Last);
            paragraph.Inlines.Add(hyperlink);
            FlowDocument document = new FlowDocument();
            document.Blocks.Add(paragraph);
            myDocument.Document = document;
        }
    }
}
