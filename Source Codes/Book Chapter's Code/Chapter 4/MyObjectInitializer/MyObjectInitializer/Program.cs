using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObjectInitializer
{
    class Program
    {
        public class StudentName
        {
            public string FirstName;
            public string LastName;
        }
        public class Student
        {
            public StudentName Student1, Student2, Student3;
        }
        public static void Main(string[] args)
        {
            var student1 = new StudentName { FirstName = "Ahmed", LastName = "Umar" };
            var student2 = new StudentName { FirstName = "Charu", LastName = "Verma" };
            var student3 = new StudentName { FirstName = "Jyoti", LastName = "Srivastava" };
            var sClass = new Student
            {
                Student1 = student1,
                Student2 = student2,
                Student3 =
                    student3
            };
            Console.WriteLine("Student1");
            Console.WriteLine("FirstName: " + student1.FirstName);
            Console.WriteLine("LastName: " + student1.LastName);
            Console.WriteLine("-------------------");

            Console.WriteLine("Student2");
            Console.WriteLine("FirstName: " + student2.FirstName);
            Console.WriteLine("LastName: " + student2.LastName);
            Console.WriteLine("-------------------");

            Console.WriteLine("Student3");
            Console.WriteLine("FirstName: " + student3.FirstName);
            Console.WriteLine("LastName: " + student3.LastName);
            Console.WriteLine("-------------------");
            Console.Write("\nPress ENTER to Quit..");

            Console.ReadLine();
        }
    }
}
