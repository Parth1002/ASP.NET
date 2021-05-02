using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNestedIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Largest of Three Numbers\n");
            Console.Write("Enter the First Number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third Number:");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (number1 > number2 && number1 > number3)
                Console.WriteLine(number1 + " is the Largest Number");
            else
                if (number2 > number3)
                    Console.WriteLine(number2 + " is the Largest Number");
                else
                    Console.WriteLine(number3 + " is the Largest Number");
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
