using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
namespace ThreadSynchronization
{
    class Program
    {
        static StringBuilder MySequence = new StringBuilder();
        static void Main(string[] args)
        {
            Thread FirstThread = new Thread(FirstFunction);
            Thread SecondThread = new Thread(SecondFunction);
            Thread ThirdThread = new Thread(ThirdFunction);
            Console.WriteLine("\nThreading Starts...\n");
            FirstThread.Start();
            SecondThread.Start();
            ThirdThread.Start();
            FirstThread.Join();
            SecondThread.Join();
            ThirdThread.Join();
            Console.WriteLine("Numbers are..\r\n{0}", MySequence.ToString());
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
        public static void FirstFunction()
        {
            lock (MySequence)
            {
                for (int number = 1; number <= 10; number++)
                {
                    Thread.Sleep(20);
                    MySequence.Append(number.ToString() + " ");
                }
            }
        }
        public static void SecondFunction()
        {
            lock (MySequence)
            {
                for (int number = 11; number <= 20; number++)
                {
                    Thread.Sleep(50);
                    MySequence.Append(number.ToString() + " ");
                }
            }
        }
        public static void ThirdFunction()
        {
            lock (MySequence)
            {
                for (int number = 21; number <= 30; number++)
                {
                    Thread.Sleep(30);
                    MySequence.Append(number.ToString() + " ");
                }
            }
        }
    }
}
