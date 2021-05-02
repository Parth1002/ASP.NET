using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavigatingRecords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            listBox1.DataSource = northwindDataSet;
            listBox1.DisplayMember = "Employees.FirstName";
            listBox1.ValueMember = "Employees.EmployeeID";
            comboBox1.DataSource = northwindDataSet;
            comboBox1.DisplayMember = "Employees.City";
            comboBox1.ValueMember = "Employess.EmployeeID";
            textBox1.DataBindings.Add(new Binding("Text", northwindDataSet,
             "Employees.EmployeeID"));
            textBox2.DataBindings.Add(new Binding("Text", northwindDataSet,
             "Employees.HomePhone"));
            toolStripStatusLabel1.Text = "You are currently at Record  " +
             Convert.ToString(this.BindingContext[northwindDataSet, "Employees"].Position + 1)
             + " of " + Convert.ToString(this.BindingContext[northwindDataSet,
             "Employees"].Count);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[northwindDataSet, "Employees"].Position = 0;
            toolStripStatusLabel1.Text = "You are currently at Record " +
            Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Position + 1) + " of " +
            Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Count);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[northwindDataSet, "Employees"].Position =
             (this.BindingContext[northwindDataSet, "Employees"].Position - 1);
            toolStripStatusLabel1.Text = "You are currently at Record " +
            Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Position + 1) + " of " +
            Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Count);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[northwindDataSet, "Employees"].Position =
             (this.BindingContext[northwindDataSet, "Employees"].Position + 1);
            toolStripStatusLabel1.Text = "You are currently at Record " +
             Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Position + 1) + " of " +
             Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[northwindDataSet, "Employees"].Position =
             (this.BindingContext[northwindDataSet, "Employees"].Count - 1);
            toolStripStatusLabel1.Text = "You are currently at Record " +
            Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Position + 1) + " of " +
            Convert.ToString(this.BindingContext[northwindDataSet,
            "Employees"].Count);

        }

    }
}
