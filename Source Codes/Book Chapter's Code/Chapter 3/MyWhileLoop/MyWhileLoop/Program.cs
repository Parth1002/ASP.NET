using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // An example of a simple while loop
            Console.WriteLine("Loop 1:");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("I = {0}", i);
                i++;
            }
            // A while loop with a boolean
            Boolean flag = false;
            i = 0;
            Console.WriteLine("\nLoop 2:");
            while (!flag)
            {
                if (i > 5)
                    flag = true;
                Console.WriteLine("I = {0}", i);
                i++;
            }

            // A loop that will never execute
            Console.WriteLine("\nLoop 3: ");
            while (i < 5)
            {
                Console.WriteLine("I = {0}", i);
                i++;
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
