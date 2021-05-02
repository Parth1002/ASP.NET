using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using MathOperation;

namespace Client 
{
	public class Program 
    {
		public static void Main(string[] args) 
		{
         	ChannelServices.RegisterChannel(new HttpChannel(), false);
			ArithmeticOperation obj = (ArithmeticOperation)Activator.GetObject(typeof(ArithmeticOperation),"http://localhost:9932/ArithmeticOperation");

			if (obj == null)
			{
				Console.WriteLine("Unable to get remote reference");
			}
			else
			{
				char b;
			do {
					Console.WriteLine("1. Addition");
					Console.WriteLine("2. Subtraction");
					Console.WriteLine("3. Multiplication");
					Console.WriteLine("4. Division");
					Console.WriteLine("Enter your choice :");
					int choice = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter value for a :");
					int num1 = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter value for b :");
					int num2 = int.Parse(Console.ReadLine());
					string msg;
					switch (choice) {
						case 1:
						msg= obj.Add(num1, num2);
						Console.WriteLine(msg);
						break;
						case 2:
						msg = obj.Subtract(num1, num2);
						Console.WriteLine(msg);
						break;
						case 3:
						msg = obj.Multiply(num1, num2);
						Console.WriteLine(msg);
						break;
						case 4:
						msg = obj.Divide(num1, num2);
						Console.WriteLine(msg);
						break;
						default:
						Console.WriteLine("no match found");
						break;
					}
					Console.WriteLine("Do you want to continue (Y/N)? :");
					b= Convert.ToChar (Console.ReadLine()); 
				}
				while (b  == Convert.ToChar("Y"));
			}
		}
	}
}

