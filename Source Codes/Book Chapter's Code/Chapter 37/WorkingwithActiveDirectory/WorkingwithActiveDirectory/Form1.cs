using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Net;


namespace WorkingwithActiveDirectory
{
    public partial class Form1 : Form
    {
        DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.1.95");
        string a = null;
        bool status;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == true)
                {
                    label3.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Enabled = true;
                    DirectoryEntries users = entry.Children;
                    DirectoryEntry user = users.Add("CN=" + textBox1.Text, "user");
                    user.Properties["userPassword"].Add(textBox2.Text);
                    user.Properties["company"].Add(textBox3.Text);
                    user.Properties["department"].Add(textBox4.Text);
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text== "" || textBox4.Text == "")
                    {
                        SetBlank();
                    }
                    else
                    {
                        user.CommitChanges();
                        label6.Text = "User details added successfully.";
                        //GetInformation();
                    }
                }
            }
            catch (Exception ex)
            {
                label6.Text = "User already exists. Please add a different user.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            entry.Path = "LDAP://192.168.1.95/CN=" + a + ",CN=Users,DC=sql, DC=local";
			entry.Username = "administrator@sql.local";
			entry.Password = "kogent@321";
			if (entry.Properties.Contains("company"))
			{
				entry.Properties["company"][0] = textBox3.Text;
			}
			else
			{
				entry.Properties["company"].Add(textBox3.Text);
			}
			if (entry.Properties.Contains("department"))
			{
				entry.Properties["department"][0] = textBox4.Text;
			}
			else
			{
				entry.Properties["department"].Add(textBox4.Text);
			}
			entry.CommitChanges();
			label6.Text = "User details modified successfully.";
			EstablishConnection();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           GetInformation();
        }
        private void SetBlank()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			label6.Text = "";
		}
        private void GetInformation()
		{
			listBox1.Items.Clear();
			using (DirectorySearcher searcher = new DirectorySearcher())
			{
				searcher.SearchRoot = entry;
				SearchResultCollection results = searcher.FindAll();
				foreach (SearchResult result in results)
				{
					ResultPropertyCollection props = result.Properties;
					foreach (string propName in props.PropertyNames)
					{
					if (propName == "name")
					{
						listBox1.Items.Add(props[propName][0]);
					}
					}
				}
				status = true;
			}
		}

        private void listBox1_Click(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void SetDetails()
		{
			SetBlank();
			textBox1.Enabled = false;
			button2.Enabled = true;
			using (DirectorySearcher searcher = new DirectorySearcher())
			{
				a = listBox1.SelectedItem.ToString();
				searcher.SearchRoot = entry;
				searcher.Filter = "(&(objectClass=user)(name=" + a + "))";
				SearchResultCollection results = searcher.FindAll();
				foreach (SearchResult result in results)
				{
				label6.Text = "Modify user details";
				label3.Visible = false;
				textBox2.Visible = false;
				ResultPropertyCollection props = result.Properties;
				foreach (string propName in props.PropertyNames)
				{
				if (propName == "name" && props[propName][0].ToString() != null)
				{
					textBox1.Text = props[propName][0].ToString();
				}
				if (propName == "company")
				{
					textBox3.Text = props[propName][0].ToString();
				}
				if (propName == "department")
				{
					textBox4.Text = props[propName][0].ToString();
				}
				}
				}
			}
		}
		private void EstablishConnection()
		{
            entry.Path = "LDAP://192.168.1.95/CN=Users, DC=sql, DC=local";
		entry.Username = "administrator@SQL.local";
		entry.Password = "kogent@321";
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            EstablishConnection();
			status = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDetails();
        }

   
    }
}
