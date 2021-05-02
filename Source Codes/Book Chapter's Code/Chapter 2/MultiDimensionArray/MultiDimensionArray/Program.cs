using System;
using System.Collections.Generic;
using System.Text;

namespace MultiDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];//Declaraing Multi-dimensional array
            for (int j = 0; j <= 2; j++)
            {
                for (int k = 0; k <= 2; k++)
                {
                    Console.WriteLine("Enter the " + (k + 1) + " element of the " + (j + 1) + " row");
                    x[j, k] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine();
                for (int k = 0; k <= 2; k++)
                {

                    Console.Write(x[j, k] + "\t");
                }
            }
            Console.ReadLine();

        }
    }
}
