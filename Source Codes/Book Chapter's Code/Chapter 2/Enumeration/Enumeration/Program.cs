using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeration
{
    class Program
    {
        public enum Color { Red = 1, Green, Yellow }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select 1 for Red, 2 for Green, and 3 for Yellow");
            string str = Console.ReadLine();
            int colInt = Int32.Parse(str);
            Color col = (Color)colInt;
            switch (col)
            {
                case Color.Red:
                    Console.WriteLine("The selected color is Red");
                    break;
                case Color.Green:
                    Console.WriteLine("The selected color is Green");
                    break;
                case Color.Yellow:
                    Console.WriteLine("The selected color is Yellow");
                    break;
                default:
                    Console.WriteLine("This number is not assigned to any color");
                    break;
            }
            Console.ReadLine();

        }
    }
}
