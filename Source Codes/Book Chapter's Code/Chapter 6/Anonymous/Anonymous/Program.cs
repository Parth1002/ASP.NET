using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
delegate void ExampleAnonyms(string str);
delegate void ExampleAnonyms1();
namespace Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleAnonyms point = delegate(string str1)
            {
                System.Console.WriteLine(str1);
            };
            point("This is an example of an anonymous method.");
            ExampleAnonyms1 point1 = delegate()
            {
                Console.WriteLine("This is an example of an anonymous method.");
                Console.Write("\nPress ENTER to quit...");
                Console.ReadLine();
            };
            point1();
        }
    }
}
