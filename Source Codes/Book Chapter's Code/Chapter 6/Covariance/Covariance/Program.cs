using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Covariance
{
    class X
    {
        public X CreateX()
        {
            Console.WriteLine("This is Class X");
            return new X();
        }
    }
    class Y : X
    {
        public Y CreateY()
        {
            Console.WriteLine("This is class Y");
            return new Y();
        }
    }
    class Program
    {
        public delegate X Create();
        public static void Foo(Create obj) { obj(); }
        static void Main(string[] args)
        {
            Create obj1 = new Create(new X().CreateX);
            Create obj2 = new Create(new Y().CreateY);
            Foo(obj1);
            Foo(obj2);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
