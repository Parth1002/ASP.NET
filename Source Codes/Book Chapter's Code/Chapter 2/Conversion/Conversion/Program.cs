using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123.45";
            // Converting str1 to a real floating point
            Single sngl1 = Convert.ToSingle(str1);
            // Converting str1 to an integer
            int x = Convert.ToInt16(sngl1);

            Console.WriteLine("Single 1 = {0}", sngl1);
            Console.WriteLine("Integer 1 = {0}", x);

            // Converting str1 to double
            double y = Convert.ToDouble(str1);
            Console.WriteLine("Double = {0}", y);
            Int16 z = Convert.ToInt16(y);
            Console.WriteLine("Int16  = {0}", z);
            Console.ReadLine();


        }
    }
}
