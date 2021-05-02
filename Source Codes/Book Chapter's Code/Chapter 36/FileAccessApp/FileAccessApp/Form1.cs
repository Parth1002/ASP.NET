using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;


namespace FileAccessApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
			bool bAF = false;
			bool bLF = false;
			try
			{
				System.IO.FileStream fs = new
				System.IO.FileStream("C:\\file.txt",
				FileMode.OpenOrCreate, FileAccess.Write);
				StreamWriter w = new StreamWriter(fs);
				w.BaseStream.Seek(0, SeekOrigin.End);
				w.WriteLine("Here is the file's text.");
				w.Write("Here is more file text." +
				System.Environment.NewLine);
				w.WriteLine("And that's about it.");
				w.Flush();
				w.Close();
				fs = new System.IO.FileStream("C:\\file.txt",
				FileMode.Open, FileAccess.Read);
				StreamReader r = new StreamReader(fs);
				r.BaseStream.Seek(0, SeekOrigin.Begin);
				TextBox1.Text = "";
				while (r.Peek() > -1)
				{
					TextBox1.Text += r.ReadLine() +
					System.Environment.NewLine;
				}
				r.Close();
				bAF = true;
			}
			catch (SecurityException ex)
			{
				bAF = false;
			}
			try
			{
				FileAccessLib.Class1 FA = new 
				FileAccessLib.Class1();
				string FileText = null;
				bLF = FA.AccessFile(ref FileText);
				TextBox2.Text = FileText;
			}
			catch
			{
				bLF = false;
			}

			StatusBar1.Text = ((bAF & bLF) ? "Both app and the lib were allowed access.": ((bAF  |  bLF) ? ((bAF & ! bLF) ? "App was but lib was not allowed access": "App wansn't but lib was allowed access"): "Neither app nor lib was allowed access."));
		}
	}
}
