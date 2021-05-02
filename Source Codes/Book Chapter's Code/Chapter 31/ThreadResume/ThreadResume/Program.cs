using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadResume
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
            Console.WriteLine("\n Thread Suspended...");
            Thread.Sleep(200);

            //Code to resume a thread
            FirstThread.Resume();
            Console.WriteLine("\n Thread Resumed...\n");
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
            finally
            {
                Console.Write("\n Press ENTER to quit...");
                Console.ReadLine();
            }
        }
    }
}
