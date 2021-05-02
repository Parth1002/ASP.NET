using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace CheckedListBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
			con.Open();
			SqlDataAdapter adp = new SqlDataAdapter("select ContactName +','+ ContactTitle as FullName from Customers", con);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Customers");
			foreach (DataRow dr in ds.Tables["Customers"].Rows)
			{
				checkedListBox1.Items.Add(dr["FullName"]);
			}

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.Text;
			label2.Text = "Checked = " + 
			 checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex);

        }
    }
}
