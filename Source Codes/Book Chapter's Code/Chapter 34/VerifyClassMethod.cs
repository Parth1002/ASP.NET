using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace VerifyClassMethod
{
    class VerifyClassMethod
    {
        public static void Main(string[] args)
        {
            // If they gave us at least two arguments,
			// check the assembly (arg 1) for a class
			// that contains a method (arg 2)
			if (args.Length >= 2)
			SearchForMethod(args[0], args[1]);
		}
		public static void SearchForMethod(
		string AssemblyName,
		string MethodName)
		{
			// Step 1: Open the assembly
			Assembly assembly = Assembly.LoadFrom(
			AssemblyName);
			if (assembly == null)
			{
				Console.WriteLine("Unable to open {0}",
				AssemblyName);
				return;
			}

			// Step 2: Loop through all classes in
			//         the assembly

			foreach (Type t in assembly.GetTypes())
			{
				// Is this a class?
				if (t.IsClass == false)
				continue; // No. Skip it

				// Get all of the methods in the class
				foreach (MethodInfo m in t.GetMethods())
				{
					if (m.Name == MethodName)
					{
						Console.WriteLine("Class {0} contains method", 
 						t.FullName);
					}
				}
			}
        }
    }
}
