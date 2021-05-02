using System;
using System.Collections.Generic;
using System.Text;

namespace SingleDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[2];
            int[] sub1 = new int[2];
            int[] sub2 = new int[2];
            int[] total = new int[2];
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " student name");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the marks of first subject");
                sub1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the marks of second subject");
                sub2[i] = int.Parse(Console.ReadLine());
                total[i] = sub1[i] + sub2[i];
            }
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("The student name is " + name[i] + " and his total marks is " + total[i]);
            }
            Console.ReadLine();

        }
    }
}
