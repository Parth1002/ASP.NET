using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArea myarea = new MyArea();
            myarea.RectArea();
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }

    class MyArea
    {
        public double RectArea()
        {
            double Length, Breadth, RectangleArea;
            Console.Write("Enter the Length of Rectangle:");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Enter the Breadth of Rectangle:");
            Breadth = double.Parse(Console.ReadLine());
            RectangleArea = Length * Breadth;
            Console.WriteLine("The Area of Rectangle is:" + RectangleArea);
            return (RectangleArea);
        }
    }
}
