using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyException
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int div = 0;
            try
            {
                div = 100 / number;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception Occured");
            }
            Console.WriteLine("Result is : " + div);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
