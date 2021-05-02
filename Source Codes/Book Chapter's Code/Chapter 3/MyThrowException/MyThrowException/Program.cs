using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyThrowException
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a Number:");
            number = int.Parse(Console.ReadLine());
            try
            {

                if (number > 10)
                    throw new Exception("Maximum Limit is 10");

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception has been Occured");
            }
            finally
            {
                Console.WriteLine("This is the Last Statement");
                Console.Write("\nPress ENTER to quit...");
                Console.ReadLine();

            }
        }
    }
}
