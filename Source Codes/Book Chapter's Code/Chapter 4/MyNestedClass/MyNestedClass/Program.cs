using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNestedClass
{
    public class Outer
    {
        public Outer(int num)
        {
            Number = num;
        }

        public class Inner
        {
            public void DisplayNumber(Outer o)
            {
                Console.WriteLine("The Number is: " + o.Number);
                Console.Write("\nPress Enter to quit...");
                Console.ReadLine();
            }
        }

        private int Number;
    }

    public class Nesting
    {
        static void Main()
        {
            Outer o1 = new Outer(100);
            Outer.Inner i1 = new Outer.Inner();
            i1.DisplayNumber(o1);
        }

    }
}
