using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNamespace;

namespace ReferenceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.MyMethod();
            Console.Write("\n\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
