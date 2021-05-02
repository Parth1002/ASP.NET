using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1472; //Declaring constant variable
            int r;
            Console.WriteLine("Enter the value of r");
            r = int.Parse(Console.ReadLine());
            double circleArea = pi * r * r;
            Console.WriteLine("The area of circle is " + circleArea);
            Console.ReadLine();
        }
    }
}
