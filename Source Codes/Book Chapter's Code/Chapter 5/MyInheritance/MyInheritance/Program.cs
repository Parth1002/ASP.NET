using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInheritance
{
    public class BaseClass
    {
        public int DataMember;
        public void BaseClassMethod()
        {
            Console.WriteLine("I am a Base Class Method()");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void DerivedClassMethod()
        {
            Console.WriteLine("I am a Derived Class Method()");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a Base Class Object
            Console.WriteLine("I am accessing Base Class Object:");
            BaseClass bc = new BaseClass();
            bc.DataMember = 1;
            bc.BaseClassMethod();
            // Create a Derived Class Object
            Console.WriteLine("");
            Console.WriteLine("I am accessing Derived Class Object:");
            DerivedClass dc = new DerivedClass();
            dc.DataMember = 2;
            dc.BaseClassMethod();
            dc.DerivedClassMethod();
            Console.Write("\nPress ENTER to quit..");
            Console.ReadLine();
        }
    }

}
