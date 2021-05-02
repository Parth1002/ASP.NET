using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntializingVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a variable at declaration
            short x = 5;
            // Initialize a variable as a copy of another
            int y = x;
            double z = y + 10.25; //assigning an integer value with a floating-point value 
            int a = (int)z; // converting the floating-point number to integer
            Console.WriteLine("X = {0} Y = {1} Z = {2}", x, y, z);
            Console.WriteLine("A = {0}", a);
            Console.ReadLine();
        }
    }
}
