using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = new int[2, 2];
            int[,] secondMatrix = new int[2, 2];
            int[,] sumMatrix = new int[2, 2];
            int i, j;
            Console.WriteLine("Enter the Elements of the First 2X2 Matrix:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the Elements of the Second 2X2 Matrix:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The Sum of the Matrices is:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                    Console.Write(+sumMatrix[i, j] + "  ");
                }
                Console.WriteLine("");
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
