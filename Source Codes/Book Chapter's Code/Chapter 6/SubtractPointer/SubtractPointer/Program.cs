using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SubtractPointer
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int* MyArray = stackalloc int[30];
            long* Subtraction;
            int* MyPointer1 = &MyArray[7];
            int* MyPointer2 = &MyArray[12];
            Subtraction = (long*)(MyPointer2 - MyPointer1);
            Console.WriteLine("The Result of Pointer Subtraction is: {0}",
             (long)Subtraction);
            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to quit....");
            Console.Read();
        }
    }
}
