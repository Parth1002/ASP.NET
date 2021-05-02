using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contravariance
{
    class Employees
    {
        public void Print()
        {
            Console.WriteLine("This is an Employees class");
        }
    }
    class Student : Employees
    {
        public void Print1()
        {
            Console.WriteLine("This is a Student class");
        }
    }

    class Program
    {
        public delegate void Method(Student Stu);
        public static void Method1(Employees Emp)
        {
        }
        public static void Method2(Student Stu1)
        {
        }
        static void Main(string[] args)
        {
            // Contravariance allows this delegate.
            Method Obj1 = Method1;
            Method Obj2 = Method2;
            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to quit....");
            Console.Read();
        }
    }
}
