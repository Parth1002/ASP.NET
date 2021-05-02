using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (true)
            {
                Console.WriteLine(number);
                number++;
                if (number <= 10)
                    continue;
                else
                    break;
            }
            Console.WriteLine("Series is breaked at number: " + number);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
