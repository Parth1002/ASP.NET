using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            for (counter = 0; ; counter++)
            {
                Console.WriteLine("I Stuck in a Loop");
            }
        }
    }
}
