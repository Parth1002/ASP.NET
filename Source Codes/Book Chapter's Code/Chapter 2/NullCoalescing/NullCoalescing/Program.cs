using System;
using System.Collections.Generic;
using System.Text;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null; //Nullable variable
            int? j = 30;	   //Nullable variable
            int k;
            k = i ?? 25; //Using ?? operator to check for null values
            Console.WriteLine("The value of k is " + k);
            k = j ?? 25; //Using ?? operator to check for null values
            Console.WriteLine("Now the value of k is " + k);
            Console.ReadLine();

        }
    }
}
