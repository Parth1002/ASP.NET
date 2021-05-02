using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Dereference
{
	class Program
	{
		unsafe static void Main(string[] args)
		{
			int Number = 100;
			int* MyPointer;
			MyPointer = &Number;
			{
				Console.WriteLine("Old Values:");
				Console.WriteLine("Number: " + Number);
				Console.WriteLine("MyPointer: " + (int)MyPointer);
				Console.WriteLine("*MyPointer: " + *MyPointer);
				*MyPointer = 50;
				Console.WriteLine("---------------------------");
				Console.WriteLine("New Values:");
				Console.WriteLine("Number: " + Number);
				Console.WriteLine("MyPointer: " + (int)MyPointer);
				Console.WriteLine("*MyPointer: " + *MyPointer);
                Console.Read();
			}
		}
	}
}

