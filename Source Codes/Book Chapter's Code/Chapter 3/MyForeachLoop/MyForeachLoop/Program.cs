using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bookTitles = new string[] { "Alice in Wonderland", 
                                                 "Pelican Brief", 
                                                 "Ignited Minds" };
            Console.WriteLine("The available book titles are: ");
            foreach (string i in bookTitles)
                Console.WriteLine("\t" + i);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
