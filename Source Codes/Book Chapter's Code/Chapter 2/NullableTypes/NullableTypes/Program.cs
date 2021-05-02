using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? var1 = null; //Declaring nullable type variable
            int var2 = 5;
            var1 = var2;   //valid
            // int? is Nullable where underlying type is int
            if (var1.HasValue == true)
            {
                Console.WriteLine("var1 = " + var1.Value);
            }
            else
            {
                Console.WriteLine("var1 = Null");
            }
            Console.ReadLine();
        }
    }
}
