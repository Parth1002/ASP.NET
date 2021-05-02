using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    public class EmployeeDetail
    {
        private string Name;
        // Accessor
        public string get()
        {
            return Name;
        }
        // Mutator
        public void set(string name)
        {
            Name = name;
        }
    }
    public class MainClass
    {
        static void Main(string[] args)
        {
            EmployeeDetail detail = new EmployeeDetail();
            detail.set("Vaidehi");
            Console.WriteLine("The Employee Name is :" + detail.get());
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
