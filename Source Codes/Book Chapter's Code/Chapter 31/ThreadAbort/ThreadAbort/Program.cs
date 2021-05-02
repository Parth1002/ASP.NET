using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadAbort
{
    class Program
    {
        static Thread FirstThread;
        static void Main(string[] args)
        {
            FirstThread = new Thread(FirstFunction);
            FirstThread.Name = "First Thread";
            FirstThread.Start();
            Console.WriteLine("Thread Started...\n");
            Thread.Sleep(200);
            FirstThread.Suspend();
            Console.WriteLine("\nThread Suspended...");
            Thread.Sleep(200);
            FirstThread.Resume();
            Console.WriteLine("\nThread Resumed...\n");
            Thread.Sleep(200);
            Console.WriteLine("\nThread Aborted...\n");

            //Code to stop the execution of a thread
            FirstThread.Abort();
        }
        public static void FirstFunction()
        {
            int number = 1;
            try
            {
                for (; number <= 25; number++)
                {
                    int time = new Random().Next(25, 50);
                    Console.WriteLine("{0} Slept for: {1} miliseconds",
                     FirstThread.Name, time.ToString());
                    Thread.Sleep(time);
                }
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("{0} Aborted after {1} iterations",
                 FirstThread.Name, number);
                Console.Write("\nPress ENTER to quit...");
                Console.ReadLine();
            }
        }
    }
}
