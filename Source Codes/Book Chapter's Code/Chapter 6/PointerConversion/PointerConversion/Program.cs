using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PointerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyNumber = 2048;
            unsafe
            {
                //Conversion of int to byte
                byte* MyPointer = (byte*)&MyNumber;
                Console.Write("The Four Bytes of Number are:");
                // Show the Four Bytes of MyNumber 
                for (int i = 0; i < sizeof(int); ++i)
                {
                    Console.Write(" {0:X2}", *MyPointer);
                    //Increase the Pointer by 1
                    MyPointer++;
                }
                Console.WriteLine();
                Console.WriteLine("The Value of Number is: {0}", MyNumber);
                Console.WriteLine("\n");
                Console.WriteLine("Press ENTER to quit....");
                Console.Read();
            }
        }
    }
}
