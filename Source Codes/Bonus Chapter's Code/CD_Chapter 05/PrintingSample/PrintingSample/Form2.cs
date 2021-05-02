using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintingSample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int pageNumber = 0;
        private void printDocument1_BeginPrint(object sender,
            System.Drawing.Printing.PrintEventArgs e)
        {
            pageNumber = 0;
        }
        private void printDocument1_PrintPage(object sender,
         System.Drawing.Printing.PrintPageEventArgs e)
        {
            pageNumber = pageNumber + 1;
            switch (pageNumber)
            {
                case 1:
                    {
                        e.Graphics.FillRectangle(Brushes.Red, new Rectangle(200, 200, 500, 500));
                        e.HasMorePages = true;
                        break;
                    }
                case 2:
                    {
                        e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(200, 200, 500, 500));
                        e.HasMorePages = false;
                        break;
                    }
            }

        }
    }
}
