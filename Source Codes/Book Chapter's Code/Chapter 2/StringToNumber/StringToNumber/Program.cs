using System;
using System.Collections.Generic;
using System.Text;

namespace StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123.45";
            string str2 = "123.00";
            // Converting both strings to floating-point numbers
            Single sngl1 = Convert.ToSingle(str1);
            Single sngl2 = Convert.ToSingle(str2);
            Console.WriteLine("Single 1 = {0}", sngl1);
            Console.WriteLine("Single 2 = {0}", sngl2);
            // Converting both strings to Double
            double x = Convert.ToDouble(str1);
            double y = Convert.ToDouble(str2);
            Console.WriteLine("Double 1 = {0}", x);
            Console.WriteLine("Double 2 = {0}", y);
            Console.ReadLine();

        }
    }
}
