using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStaticProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of objects:{0}", CounterClass.NumberOfObjects);
            CounterClass object1 = new CounterClass();
            Console.WriteLine("Number of objects:{0}", CounterClass.NumberOfObjects);
            CounterClass object2 = new CounterClass();
            Console.WriteLine("Number of objects:{0}", CounterClass.NumberOfObjects);
            CounterClass object3 = new CounterClass();
            Console.WriteLine("Number of objects:{0}", CounterClass.NumberOfObjects);
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }
    public class CounterClass
    {
        private static int number = 0;

        public CounterClass()
        {
            number++;
        }

        public static int NumberOfObjects
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
