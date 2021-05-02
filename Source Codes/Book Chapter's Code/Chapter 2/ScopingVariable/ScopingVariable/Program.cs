using System;
using System.Collections.Generic;
using System.Text;

namespace ScopingVariable
{
    class Program
    {

        static int x = 10;
        static void Main(string[] args)
        {
            // Locally defined copy of x
            int x = 5;
            int y = x;
            double z = y + 10.25;
            int a = (int)z;
            // Output X. Which one gets written?
            Console.WriteLine("X = {0} Y = {1} Z = {2}", x, y, z);
            Console.WriteLine("A = {0}", a);
            // Force the output of the class level x variable
            Console.WriteLine("Class Level X = {0}", Program.x);
            Console.ReadLine();

        }
    }
}
