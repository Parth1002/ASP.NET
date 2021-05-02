using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyThreadsPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread FirstThread = new Thread(FirstFunction);
            Thread SecondThread = new Thread(SecondFunction);
            Thread ThirdThread = new Thread(ThirdFunction);
            FirstThread.Name = "First Thread";
            SecondThread.Name = "Second Thread";
            ThirdThread.Name = "Third Thread";

            //Setting priorities for threads
            FirstThread.Priority = ThreadPriority.Lowest;
            SecondThread.Priority = ThreadPriority.Highest;
            ThirdThread.Priority = ThreadPriority.AboveNormal;
            Console.WriteLine("Threading Starts...\n");
            ThirdThread.Start();
            SecondThread.Start();
            FirstThread.Start();
        }
        public static void FirstFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("First  Thread  Displays: " + number);
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
        public static void SecondFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("Second Thread  Displays: " + number);
            }
        }
        public static void ThirdFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("Third  Thread  Displays: " + number);
            }
        }
    }

}