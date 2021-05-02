using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class StudentDetail
    {
        private string Name;
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
    }
    public class MainClass
    {
        public static void Main(string[] args)
        {
            StudentDetail detail = new StudentDetail();
            detail.StudentName = "Ravi Srivastava";
            Console.WriteLine("The Student Name is :{0}", detail.StudentName);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
