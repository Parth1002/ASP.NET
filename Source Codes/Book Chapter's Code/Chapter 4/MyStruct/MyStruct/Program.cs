using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStruct
{
    public struct X
    {
        public int x;
        public int y;
        public int z;
    }
    class Foo
    {
        static void Main(string[] args)
        {
            X x;
            x.x = 1;
            x.y = 2;
            x.z = 3;
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x.x, x.y, x.z);
            X x1 = new X();
            Console.WriteLine("X = {0}, Y = {1}, Z = {2}", x1.x, x1.y, x1.z);
            Console.Write("\nPress Enter to quit...");
            Console.ReadLine();
        }

    }
}
