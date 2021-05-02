using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //Namespace required to enable threading


namespace MyThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread FirstThread = new Thread(FirstFunction); //Code to create a thread
            Console.WriteLine("Threading Starts...\n");
            FirstThread.Start();//Starting the thread
        }
        public static void FirstFunction()
        {
            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine("First Thread  Displays: " + number);
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
