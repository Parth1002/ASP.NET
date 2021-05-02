using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SampleDelegate
{
    public struct Employee
    {
        public string strname;
        public string LName;
        public decimal Sal;
        public bool Stat;
        public Employee(string name, string lname, decimal salary,
        bool status)
        {
            strname = name;
            LName = lname;
            Sal = salary;
            Stat = status;
        }
    }
    // Declaring a delegate type 
    public delegate void EmployeeDelegateOpert(Employee employee);
    public class EmpDB
    {
        // List of all Employees in the employee database:
        ArrayList List = new ArrayList();
        // Adding a Employee to the database:
        public void AddEmp(string name, string lname, decimal salary, bool
            status)
        {
            List.Add(new Employee(name, lname, salary, status));
        }
        public void EmpStatus(EmployeeDelegateOpert ProcEmp)
        {
            foreach (Employee b in List)
            {
                if (b.Stat)
                    ProcEmp(b); //calling the delegate
            }
        }
    }
    // Using the EmployeeData classes
    namespace EmpClient
    {
        class Salary
        {
            int TotalEmp = 0;
            decimal EmpSalary = 0.0m;
            internal void AddSalary(Employee employee)
            {
                TotalEmp += 1;
                EmpSalary += employee.Sal;
            }
            internal decimal AvgSalary()
            {
                return EmpSalary / TotalEmp;
            }
        }
        // Class to test the Employee database:
        class TestEmployees
        {
            static void Print(Employee b)
            {
                System.Console.WriteLine("   {0}", b.strname);
            }
            static void Main()
            {
                EmpDB empDataBase = new EmpDB();
                // adding employees to database
                AddEmployee(empDataBase);
                System.Console.WriteLine("Status of the Employees:");
                empDataBase.EmpStatus(Print);

                Salary salAdder = new Salary();

                // a new delegate object associated with the nonstatic 
                // method AddSalaryum on the object salAdder
                empDataBase.EmpStatus(salAdder.AddSalary);
                Console.WriteLine("Average Salary of the Employee: ${0:#.##}",
                salAdder.AvgSalary());
                Console.Write("\nPress ENTER to quit...");
                Console.ReadLine();
            }
            // Initialize the Employee database with some Employees:
            static void AddEmployee(EmpDB empDataBase)
            {
                empDataBase.AddEmp("Peter", "Wilkins", .100m, true);
                empDataBase.AddEmp("Tom", "Johnson", 25.35m, true);
                empDataBase.AddEmp("Pat", "DAvid", 50.90m, false);
                empDataBase.AddEmp("Henry", "Williams", 15.20m, true);
            }
        }
    }
}
