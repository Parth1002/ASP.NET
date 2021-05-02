using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace UsingExpandoObject
{

    class Program
    {
        static void Main(string[] args)
        {
            // creating variables of dynamic data type
            dynamic son, father;

            // initializing an oject of ExpandoObject class
            son = new ExpandoObject();
            son.Name = "Son";
            son.Age = 20;

            father = new ExpandoObject();
            father.Name = "Father";
            father.Age = 48;
            father.Children= 3;

            WriteFamily(father);
            WriteFamily(son);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to quit....");
            Console.Read();
        }
        private static void WriteFamily(dynamic member)
        {
            Console.WriteLine("{0} is {1} years old.", member.Name, member.Age);
           // The following statement causes an exception
            // if you pass the father object.
            // Console.WriteLine("Father has {0} children", member.Children);
        }
    }
}
