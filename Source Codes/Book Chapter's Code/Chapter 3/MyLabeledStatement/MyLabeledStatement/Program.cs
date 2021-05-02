using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLabeledStatement
{
    class Program
    {
        static void Main(string[] args)
        {
                        int x = 100, y = 4;
            int count = 0;
            string[,] myArray = new string[x, y];

            // Initialize the array:
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    myArray[i, j] = (++count).ToString();

            // Read input:
            Console.Write("Enter the Number to Search for:");

            // Input a string:
            string myNumber = Console.ReadLine();

            // Search:
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    if (myArray[i, j].Equals(myNumber))
                        goto Found;

            Console.WriteLine("The Number {0} is not Found.", myNumber);
            goto Finish;

        Found:
            Console.WriteLine("The Number {0} is Found.", myNumber);

        Finish:
            Console.WriteLine("End of Search.");
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }

        }
    }

