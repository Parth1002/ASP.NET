using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverload
{
    public class Shape
    {
        public void Area(int Side)
        {
            int SquareArea = Side * Side;
            Console.WriteLine("The Area of Square is: " + SquareArea);
        }
        public void Area(int Length, int Breadth)
        {
            int RectangleArea = Length * Breadth;
            Console.WriteLine("The Area of Rectangle is: " + RectangleArea);
        }
        public void Area(double Radius)
        {
            double CircleArea = 3.14 * Radius * Radius;
            Console.WriteLine("The Area of Circle is: " + CircleArea);
        }
        public double Area(double Base, double Height)
        {
            double TriangleArea = (Base * Height) / 2;
            Console.WriteLine("The Area of Triangle is: " + TriangleArea);
            return TriangleArea;
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Area(15);
            shape.Area(10, 20);
            shape.Area(10.5);
            shape.Area(15.5, 20.4);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
