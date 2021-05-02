using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread FirstThread = new Thread(FirstFunction);
            Console.WriteLine("Threading Starts...\n");
            FirstThread.Start();
            Console.ReadLine();
        }
        public static void FirstFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("First Thread Displays: " + number);
                // Putting the thread on sleep  for 1 second			
                Thread.Sleep(1000);
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }

    }
}
