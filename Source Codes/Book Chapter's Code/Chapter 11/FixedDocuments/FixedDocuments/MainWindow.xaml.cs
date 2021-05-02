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
using System.IO;
using System.Windows.Forms;
using System.Windows.Xps.Packaging;

namespace FixedDocuments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddCommandBindings(ApplicationCommands.Open, OpenCommandHandler);
            AddCommandBindings(ApplicationCommands.Close, CloseCommandHandler);
        }
        private void OpenCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Xps Documents (*.xps)|*.xps";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (_xpsDocument != null)
                    _xpsDocument.Close();
                try
                {
                    _xpsDocument = new
                    XpsDocument(dlg.FileName, System.IO.FileAccess.Read);
                }
                catch (UnauthorizedAccessException)
                {
                    System.Windows.MessageBox.Show(
                    String.Format("Unable to access {0}", dlg.FileName));
                    return;
                }
                docViewer.Document = _xpsDocument.GetFixedDocumentSequence();
                _fileName = dlg.FileName;
            }
        }
        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        private void AddCommandBindings(ICommand command, ExecutedRoutedEventHandler
         handler)
        {
            CommandBinding cmdBindings = new CommandBinding(command);
            cmdBindings.Executed += handler;
            CommandBindings.Add(cmdBindings);
        }
        private XpsDocument _xpsDocument;
        private string _fileName;

    }
}
