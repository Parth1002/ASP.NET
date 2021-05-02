using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace ODBCDataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet1.Products);          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection connection = new OdbcConnection();
            connection.ConnectionString = "Dsn=myDSN; UID=; Pwd=;";
            string SQL = "select * from Products";
            connection.Open();
            OdbcCommand cmd = new OdbcCommand(SQL, connection);
            OdbcDataReader dr = cmd.ExecuteReader();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Products");
            dt.Load(dr);
            ds.Tables.Add(dt);
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = ds.Tables[0];
            connection.Close();
            dr.Close();
            cmd.Dispose();
            connection.Dispose();
        }
    }
}
