using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysizeanddimension
{
    class Program
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.WriteLine("OneDArray Row {0} = {1}", i, arr[i]);
        }
        public static void PrintArrayRank(int[,] arr)
        {
            Console.WriteLine("PrintArrayRank: {0} dimensions", arr.Rank);
        }

        static void Main(string[] args)
        {
            // A dynamic array of 10 elements
            int[] x = new int[10];
            for (int i = 0; i < 10; ++i)
                x[i] = i;
            PrintArray(x);
            // A multiple dimensioned array
            int[,] y = new int[10, 20];
            for (int k = 0; k < 10; ++k)
                for (int i = 0; i < 20; ++i)
                    y[k, i] = i * k;
            PrintArrayRank(y);
            Console.ReadLine();

        }
    }
}
