using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SimpleBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet3.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter3.Fill(this.northwindDataSet3.Customers);
            // TODO: This line of code loads data into the 'northwindDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter2.Fill(this.northwindDataSet2.Customers);
            // TODO: This line of code loads data into the 'northwindDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.northwindDataSet1.Customers);
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.MoveNext();
            this.customersBindingSource1.MoveNext();
            this.customersBindingSource2.MoveNext();
            this.customersBindingSource3.MoveNext();

        }

       

      

      
       
    }
}
