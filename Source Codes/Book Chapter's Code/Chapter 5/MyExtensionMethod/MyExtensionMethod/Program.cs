using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyExtensionMethod
{
    public static class MyClass
    {
        public static int MyExtensionMethod(this string Number)
        {
            return Int32.Parse(Number);
        }
        public static int MyStaticMethod(string Number)
        {
            return Int32.Parse(Number);
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            string Number = "100";
            int ext = Number.MyExtensionMethod();		// Line A
            Console.WriteLine("The Output from MyExtensionMethod()");
            Console.WriteLine(ext);
            int stat = MyClass.MyStaticMethod(Number);	// Line B
            Console.WriteLine("");
            Console.WriteLine("The Output from MyStaticMethod()");
            Console.WriteLine(stat);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
