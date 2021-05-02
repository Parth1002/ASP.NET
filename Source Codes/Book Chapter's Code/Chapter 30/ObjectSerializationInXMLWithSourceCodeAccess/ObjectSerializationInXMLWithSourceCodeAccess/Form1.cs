using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace ObjectSerializationInXMLWithSourceCodeAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            	Employee emp = new Employee();
	            emp.ID = 101;
	            emp.Name = "Kabir";
	            emp.Salary = 60000;
	            TextWriter tw = new StreamWriter("employee.xml");      
	            XmlSerializer xs = new XmlSerializer(typeof(Employee));      
	            xs.Serialize(tw, emp);
	            tw.Close();
	            webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory	+ "employee.xml");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("employee.xml", FileMode.Open);
            XmlSerializer newXs = new XmlSerializer(typeof(Employee));
            Employee emp1 = (Employee)newXs.Deserialize(fs);
            if (emp1 != null)
            {
                listBox1.Items.Add(emp1.ID);
                listBox1.Items.Add(emp1.Name);
                listBox1.Items.Add(emp1.Salary);
            }
            fs.Close();           

        }
    }
    public class Employee
    {
        private int empID;
        private string empName;
        private Decimal empSalary;
        [XmlElement()]
        public int ID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
        [XmlElement()]
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        [XmlElement()]
        public decimal Salary
        {
            get
            {
                return empSalary;
            }
            set
            {
                empSalary = value;
            }
        }
    }

}
