using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleObject = new SimpleClass();
            simpleObject.simpleMethod();
        }
    }
    class SimpleClass
    {
        public void simpleMethod()
        {
            Console.WriteLine("A simple method");
        }
    }
}
