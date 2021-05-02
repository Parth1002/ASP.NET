using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating more than one thread in the application
            Thread FirstThread = new Thread(FirstFunction);
            Thread SecondThread = new Thread(SecondFunction);
            Thread ThirdThread = new Thread(ThirdFunction);
            Console.WriteLine("\nThreading Starts...\n");

            //Starting more than one thread in the application
            FirstThread.Start();
            SecondThread.Start();
            ThirdThread.Start();
        }
        public static void FirstFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("First  Thread  Displays: " + number);
                Thread.Sleep(200);
            }
        }
        public static void SecondFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("Second Thread  Displays: " + number);
                Thread.Sleep(500);
            }
        }
        public static void ThirdFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("Third  Thread  Displays: " + number);
                Thread.Sleep(700);
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
