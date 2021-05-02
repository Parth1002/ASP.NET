using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuandStatusStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            toolStripStatusLabel1.Text = "You are currently at Record  " +
         Convert.ToString(this.BindingContext[northwindDataSet, "Order Details"].Position +
         1) + " of " + Convert.ToString(this.BindingContext[northwindDataSet,"Order Details"].Count);

        }

        private void orderIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = northwindDataSet;
            listBox1.DisplayMember = "Order Details.OrderID";

        }

        private void productIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.DataSource = northwindDataSet;
            listBox1.DisplayMember = "Order Details.ProductID";

        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = northwindDataSet;
            listBox1.DisplayMember = "Order Details.UnitPrice";

        }

        private void quantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = northwindDataSet;
            listBox1.DisplayMember = "Order Details.Quantity";

        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = northwindDataSet;
            listBox1.DisplayMember = "Order Details.Discount";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[northwindDataSet, "Order Details"].Position =
         (this.BindingContext[northwindDataSet, "Order Details"].Position + 1);
            toolStripStatusLabel1.Text = "You are currently at Record " +
            Convert.ToString(this.BindingContext[northwindDataSet, "Order Details"].Position +
            1) + " of " + Convert.ToString(this.BindingContext[northwindDataSet,"Order Details"].Count);

        }
    }
}
