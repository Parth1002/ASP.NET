using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Illustrate a simple for loop that counts from 1 to 5
            for (int i = 0; i < 5; ++i)
                Console.WriteLine("I = {0}", i);

            // Illustrate two loops to first find a letter in a string
            // and then to print it out until a space is encountered.
            // This shows you how to skip initialization in the second
            // loop
            int nPos = 0;
            string s = "this is a test of the emergency broadcast system";

            for (nPos = 0; nPos < s.Length; ++nPos)
                if (s[nPos] == 'b')
                    break;
            for (; nPos < s.Length; ++nPos)
            {
                if (s[nPos] == ' ')
                    break;
                Console.Write(s[nPos]);
            }
            Console.WriteLine("\n");

            // Finally, illustrate how to use the for loop 
            // for something
            // other than an integer and how to change the increment
            int state = 0;
            for (double d = 0.0; d < 5.0; )
            {
                Console.WriteLine("D = {0}", d);
                switch (state)
                {
                    case 0:
                        d += 0.1;
                        break;
                    case 1:
                        d += 0.2;
                        break;
                    case 2:
                        d += 0.5;
                        break;
                }
                state++;
                if (state > 2)
                    state = 0;
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
