using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySealedClass
{
    sealed class MyClass
    {
        string fName;
        string lName;
        int Age;
        public void GetDetail()
        {
            Console.Write("Enter Your First Name:");
            fName = Console.ReadLine();
            Console.Write("Enter Your Last Name:");
            lName = Console.ReadLine();
            Console.Write("Enter Your Age:");
            Age = int.Parse(Console.ReadLine());
        }
        public void ShowDetail()
        {
            Console.WriteLine(fName + " " + lName + " you are " + Age + " Years Old");
        }
    }
    // Following lines shows compiler error as Sealed class cannot be inherited
    /* class Derived : MyClass
     {
     }*/

    class MainClass
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.GetDetail();
            obj.ShowDetail();
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
