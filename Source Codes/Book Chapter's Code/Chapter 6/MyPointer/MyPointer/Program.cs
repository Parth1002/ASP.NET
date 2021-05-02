using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPointer
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int Number = 100;
            int* MyPointer;
            MyPointer = &Number;
            {
                Console.WriteLine("The Value of 'Number' is: " + Number);
                Console.WriteLine("The Value of 'MyPointer' is: " + (int)MyPointer);
                Console.WriteLine("\n");
                Console.WriteLine("Press ENTER to quit...");
                Console.Read();
            }
        }
    }
}
