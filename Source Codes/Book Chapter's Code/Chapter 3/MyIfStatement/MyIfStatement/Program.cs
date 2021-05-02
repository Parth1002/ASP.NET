using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the year value (yyyy) :");
            year = Int32.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("The year {0} is a leap year ", year);
            else
                Console.WriteLine("The year {0} is not a leap year ", year);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }

    }
}
