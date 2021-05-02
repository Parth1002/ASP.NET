using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyReferenceArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

			Console.WriteLine("Before calling non-ref function, x = {0}", x);
			NonRefFunction(x);
			Console.WriteLine("\nAfter calling non-ref function, x = {0}", x);
            		RefFunction(ref x);
			Console.WriteLine("\nAfter calling ref function, x = {0}", x);
			Console.Write("\nPress ENTER to quit..");
			Console.ReadLine();
        }

        static void NonRefFunction(int x)
		{
			Console.WriteLine("Top of NonRefFunction. X = {0}", x);
			x = x + 10;
			Console.WriteLine("Bottom of NonRefFunction. X = {0}", x);
		}
		static void RefFunction(ref int x)
		{
			Console.WriteLine("Top of RefFunction. X = {0}", x);
			x = x + 10;
			Console.WriteLine("Bottom of RefFunction. X = {0}", x);
		}

    }
}
