using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, a simple do loop that
            // increments a counter
            int i = 0;
            Console.WriteLine("Loop 1:");
            do
            {
                Console.WriteLine("I = {0}", i);
                i++;
            }
            while (i < 5);
            // Next, the same case, but using a 
            // boolean rather than an index
            i = 0;
            Boolean done = false;
            Console.WriteLine("\nLoop 2:");
            do
            {
                Console.WriteLine("I = {0}", i);
                i++;
                if (i > 5)
                    done = true;
            }
            while (!done);
            // Finally, a conditional that is true before
            // You get into the loop
            do
            {
                Console.WriteLine("Into Loop 3");
            }
            while (!done);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();   

        }
    }
}
