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

namespace TextPointerClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WrapPanel panel = new WrapPanel();
			RichTextBox richTextBox = new RichTextBox();
			richTextBox.ContextMenu = new MyContextMenu(richTextBox);
			richTextBox.Document.Blocks.Clear();
			richTextBox.Document.Blocks.Add(new Paragraph(new Run("Right-click the text to use and display the context menu and format the text on which the pointer is.")));
			richTextBox.ContextMenuOpening += new 
			ContextMenuEventHandler(richTextBox_ContextMenuOpening);
			panel.Children.Add(richTextBox);
			myWindow.Content = panel;
			myWindow.Show();
		}
		void richTextBox_ContextMenuOpening(object sender, ContextMenuEventArgs e)
		{
			RichTextBox rtb = sender as RichTextBox;
			if (rtb == null) return;
			ContextMenu contextMenu = rtb.ContextMenu;
			contextMenu.PlacementTarget = rtb;
			TextPointer position = rtb.Selection.Start;
			if (position == null) return;
			Rect positionRect = position.GetCharacterRect(LogicalDirection.Forward);
			contextMenu.HorizontalOffset = positionRect.Right;
			contextMenu.VerticalOffset = positionRect.Left;
			contextMenu.IsOpen = true;
			e.Handled = true;
		}
	}
	public class MyContextMenu : ContextMenu
	{
		private RichTextBox _rtb;
		public MyContextMenu(RichTextBox rtb): base()
		{
			_rtb = rtb;
			MenuItem menuItemBold = new MenuItem();
			menuItemBold.Header = "Bold";
			menuItemBold.Command = EditingCommands.ToggleBold;
			this.Items.Add(menuItemBold);
			MenuItem menuItemItalic = new MenuItem();
			menuItemItalic.Header = "Italic";
			menuItemItalic.Command = EditingCommands.ToggleItalic;
			this.Items.Add(menuItemItalic);
			MenuItem menuItemUnderline = new MenuItem();
			menuItemUnderline.Header = "Underline";
			menuItemUnderline.Command = EditingCommands.ToggleUnderline;
			this.Items.Add(menuItemUnderline);
			MenuItem center = new MenuItem();
			center.Header = "Align Center";
			center.Command = EditingCommands.AlignCenter;
			this.Items.Add(center);
        }
    }
}
