using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace DynamicInvoke
{
    interface IMyInterface
    {
        void PrintAString(string s);
        void PrintAnInteger(int i);
        void PrintSomeNumbers(string desc, int i, double d);
        int GetANumber(string s);
    }
    public class DoMyInterface : IMyInterface
    {
        public DoMyInterface() { }
        public void PrintAString(string s)
        {
            Console.WriteLine("PrintAString: {0}", s);
        }
        public void PrintAnInteger(int i)
        {
            Console.WriteLine("PrintAnInteger: {0}", i);
        }
        public void PrintSomeNumbers(string desc, int i, double d)
        {
            Console.WriteLine("PrintSomeNumbers:");
            Console.WriteLine("String: {0}", desc);
            Console.WriteLine("Integer: {0}", i);
            Console.WriteLine("Double: {0}", d);
        }
        public int GetANumber(string s)
        {
            Console.WriteLine("GetANumber: {0}", s);
            return 34;
        }
        public int DoItAll(string s, int i, double d)
        {
            IMyInterface mi = (IMyInterface)this;
            mi.PrintSomeNumbers(s, i, d);
            return mi.GetANumber(s);
        }
    }
    class Program
    {
        public static void DoDynamicInvocation(string assembly)
		{
			Assembly a = Assembly.LoadFrom(assembly);
			foreach (Type t in a.GetTypes())
			{
				if (t.IsClass == false)
				continue;
				if (t.GetInterface("IMyInterface") == null)
				continue;
				Console.WriteLine("Creating instance of class {0}",
				t.FullName);
				object obj = Activator.CreateInstance(t);
				object[] args = { "Dynamic", 1, 98.6 };
				object result;
				Console.WriteLine("Invoking method DoItAll	dynamically");
				try
				{
					result = t.InvokeMember("DoItAll",
					BindingFlags.Default |
					BindingFlags.InvokeMethod,
					null,
					obj,
					args);
					Console.WriteLine("Result of dynamic call:{0}", result);

					// Call an interface method
					object[] args2 = { 12345 };
					t.InvokeMember("PrintAnInteger", BindingFlags.Default |						BindingFlags.InvokeMethod, null, obj, args2);
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception: {0}", e);
				}
			}
		}
        static void Main(string[] args)
        {
            DoMyInterface dmi = new DoMyInterface();
			dmi.PrintSomeNumbers("PrintEm", 1, 12.45);
			int i = dmi.GetANumber("GiveMeOne");
			Console.WriteLine("I = {0}", i);
			DoDynamicInvocation(args[0]);
        }
    }
}
