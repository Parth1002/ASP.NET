using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace OLEDBExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + @"C:\Users\Anil\Desktop\book1.xls;" + "Excel 12.0;HDR=YES;";
            OleDbConnection ExcelConnection = new OleDbConnection(ConnectionString);
            OleDbDataAdapter ad = new OleDbDataAdapter();
            ad.SelectCommand = new OleDbCommand("SELECT * FROM [Contacts$]",
            ExcelConnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
