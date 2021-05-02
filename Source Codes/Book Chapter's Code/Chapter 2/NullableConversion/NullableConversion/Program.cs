using System;
using System.Collections.Generic;
using System.Text;

namespace NullableConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 123;
            //Assigning value of integer variable m to nullable integer variable
            int? a = m;
            Console.WriteLine("The value of a is " + a);
            //Assigning value of nullable integer variable to nullable double variable
            double? b = a;
            Console.WriteLine("The value of nullable double variable is " + b);
            //Converting nullable double to nullable int and assigning the value to nullable integer variable
            int? c = (int?)b;
            Console.WriteLine("The value of nullable integer variable is " + c);
            //Converting nullable int to integer type and assigning value to integer variable
            int n = (int)c;
            Console.WriteLine("The value of integer variable is " + n);
            Console.ReadLine();

        }
    }
}
