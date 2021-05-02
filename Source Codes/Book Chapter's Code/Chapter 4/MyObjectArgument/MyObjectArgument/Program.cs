using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObjectArgument
{
    class Program
    {
        public class Employee
        {
            public string name;
            public string department;
            public double salary;
            public void EmployeeDetails()
            {
                Console.WriteLine("Employee Details");
                Console.Write("Enter Name:");
                name = Console.ReadLine();
                Console.Write("Enter Department:");
                department = Console.ReadLine();
                Console.Write("Enter Salary in Rs:");
                salary = double.Parse(Console.ReadLine());
            }

            public void ShowDetails()
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Department:" + department);
                // Passing the object to the CalcTax method by using this:
                Console.WriteLine("Tax is Rs." + Tax.CalcTax(this));
                Console.Write("\nPress ENTER to quit...");
                Console.ReadLine();
            }

            public class Tax
            {
                public static double CalcTax(Employee E)
                {
                    return (0.08 * (E.salary));
                }
            }

            static void Main(string[] args)
            {
                // Create object:
                Employee E1 = new Employee();
                E1.EmployeeDetails();
                E1.ShowDetails();

            }
        }
    }
}
