using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBreakLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to break out of a for loop, two ways.
            Console.WriteLine("Loop 1:");
            for (int i = 0; i < 5; ++i)
            {
                if (i == 3)
                    break;
                Console.WriteLine("I = {0}", i);
            }
            Boolean done = false;
            Console.WriteLine("\nLoop 2:");
            for (int i = 0; i < 5 && done == false; ++i)
            {
                if (i == 2)
                    done = true;
                Console.WriteLine("I = {0}", i);
            }
            // Another method using a goto
            done = false;
            int counter = 0;
            Console.WriteLine("\nLoop 3:");
            do
            {
                if (counter == 5)
                    goto handle_done;
                Console.WriteLine("Counter: {0}", counter);
                counter++;
                goto not_done;

            handle_done:
                done = true;
            not_done:
                Console.WriteLine("End of Loop 3");
            }
            while (!done);
            Console.WriteLine("\nLoop 4:");
            for (int i = 0; i < 5; ++i)
            {
                if (i == 2)
                    i = 5;
                Console.WriteLine("I = {0}", i);
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
