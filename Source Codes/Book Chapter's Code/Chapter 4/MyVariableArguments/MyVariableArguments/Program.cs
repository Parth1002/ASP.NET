using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyVariableArguments
{
    class Program
    {
        public static int GetSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("The Sum is:");
            Console.WriteLine(GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(GetSum(2, 4, 6, 8));
            Console.WriteLine("\nPress ENTER to quit..");
            Console.ReadLine();

        }
    }
}
