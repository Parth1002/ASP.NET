﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ComboBoxControl
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
			SqlCommand cmd = new SqlCommand("select * from Customers", con);
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adp.Fill(ds, "Customers");
			comboBox1.DataSource = ds.Tables["Customers"];
			comboBox1.DisplayMember = "CustomerID";

        }
    }
}
