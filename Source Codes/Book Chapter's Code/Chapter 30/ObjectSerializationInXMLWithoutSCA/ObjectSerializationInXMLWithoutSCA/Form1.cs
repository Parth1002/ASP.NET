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

namespace ObjectSerializationInXMLWithoutSCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlAttributes xa = new XmlAttributes();
            xa.XmlElements.Add(new XmlElementAttribute("employee", typeof(Employee)));
            Employee newEmp = new Employee();
            newEmp.ID = 102;
            newEmp.Name = "M.K. Verma";
            newEmp.Salary = 60000;
            TextWriter tw = new StreamWriter("newEmployee.xml");
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(tw, newEmp);
            tw.Close();
            webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory + "newEmployee.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("newEmployee.xml", FileMode.Open);
            XmlSerializer newXs = new XmlSerializer(typeof(Employee));
            Employee newEmp1 = (Employee)newXs.Deserialize(fs);
            if (newEmp1 != null)
            {
                listBox1.Items.Add(newEmp1.ID);
                listBox1.Items.Add(newEmp1.Name);
                listBox1.Items.Add(newEmp1.Salary);
            }
            fs.Close();
        }
    }
    [XmlRoot()]
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
