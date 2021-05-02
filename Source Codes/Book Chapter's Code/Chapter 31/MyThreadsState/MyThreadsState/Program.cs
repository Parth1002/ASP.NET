using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace MyThreadsState
{
    public class Program
    {
        static Thread FirstThread;
        static Thread SecondThread;
        static Thread ThirdThread;
        public static void Main(string[] args)
        {
            FirstThread = new Thread(FirstFunction);
            SecondThread = new Thread(SecondFunction);
            ThirdThread = new Thread(ThirdFunction);
            FirstThread.Name = "First Thread";
            SecondThread.Name = "Second Thread";
            ThirdThread.Name = "Third Thread";
            StateOfThreads("Main() Before Starting the Threads..");
            FirstThread.Start();
            SecondThread.Start();
            ThirdThread.Start();
            StateOfThreads("Main() Before Ending the Threads...");
        }
        // Writting a function for determining the state of the threads
        public static void StateOfThreads(string position)
        {
            Console.WriteLine("\r\nIn {0}", position);
            Console.WriteLine("Thread Name : {0}, Thread State : {1}", FirstThread.Name, FirstThread.ThreadState);
            Console.WriteLine("Thread Name : {0}, Thread State : {1}", SecondThread.Name, SecondThread.ThreadState);
            Console.WriteLine("Thread Name : {0}, Thread State : {1}\r\n", ThirdThread.Name, ThirdThread.ThreadState);
        }
        public static void FirstFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("First  Thread  Displays: " + number);
                Thread.Sleep(200);
            }
            StateOfThreads("FirstFunction()");
        }
        public static void SecondFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("Second Thread  Displays: " + number);
                Thread.Sleep(500);
            }
            StateOfThreads("SecondFunction()");
        }
        public static void ThirdFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("Third  Thread  Displays: " + number);
                Thread.Sleep(700);
            }
            StateOfThreads("ThirdFunction()");
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
