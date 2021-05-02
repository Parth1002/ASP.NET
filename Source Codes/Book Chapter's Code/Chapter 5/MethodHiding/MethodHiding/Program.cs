using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodHiding
{
    class BaseClass
    {
        public void MyMethod()
        {
            Console.WriteLine("I am in Base Class");
        }
    }
    class DerivedClass : BaseClass
    {
        public new void MyMethod()
        {
            Console.WriteLine("I am in Derived Class");
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            bc.MyMethod();
            dc.MyMethod();
            bc = new DerivedClass();
            bc.MyMethod(); //BaseClass Method 
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
