using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;


namespace AccessXMLData
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = @"Data Source=.;Initial Catalog=MyData;Integrated Security=True";
            var con = new SqlConnection(connection);
            var command = con.CreateCommand();
            command.CommandText = "Select * from XMLDataTb";
            con.Open();
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            StringBuilder xmldata = new StringBuilder("-----Employees-----", 40);
            Console.WriteLine(xmldata.ToString());
            while (reader.Read())
            {
                SqlXml xml = reader.GetSqlXml(1);
                XmlReader xmlreader = xml.CreateReader();
                while (xmlreader.Read())
                {
                    if (xmlreader.Name == "Employee" && xmlreader.IsStartElement())
                    {
                        Console.WriteLine("Employee: {0}", xmlreader.GetAttribute("EmpID"));
                    }
                    else if (xmlreader.Name == "Name" && xmlreader.IsStartElement())
                    {
                        Console.WriteLine("Name: {0}", xmlreader.ReadString());
                    }
                    else if (xmlreader.Name == "Address" && xmlreader.IsStartElement())
                    {
                        Console.WriteLine("Address: {0}", xmlreader.ReadString());
                    }
                    else if (xmlreader.Name == "Phone" && xmlreader.IsStartElement())
                    {
                        Console.WriteLine("Phone: {0}", xmlreader.ReadString());
                    }
                }
                xmlreader.Close();
                Console.WriteLine();
            }
            reader.Close();

        }
    }
}
