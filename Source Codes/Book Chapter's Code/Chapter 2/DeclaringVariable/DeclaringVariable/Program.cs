using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclaringVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            short x;    //Declaring short type variable
            int y;      //Declaring integer type variable
            double z;   //Declaring double type variable
            x = 6;
            y = 10;
            z = x + y;
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x, y, z);
            Console.ReadLine();
        }
    }
}
