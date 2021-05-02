using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.Write("Enter the Name of a Month: ");
            month = Console.ReadLine().ToUpper();
            switch (month)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine(month + " has 31 days");
                    break;
                case "APRIL":
                case "JUNE":
                case "SEPTEMBER":
                case "NOVEMBER":
                    Console.WriteLine(month + " has 30 days");
                    break;
                case "FEBRUARY":
                    Console.WriteLine(month + " has 28 or 29 days");
                    break;
                default:
                    Console.WriteLine("You have entered an invalid month name");
                    break;
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
