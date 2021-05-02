using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace ObtainClassInformation
{
    class Program
    {
       public static void ShowInterfaces(Type t) 
		{
			Type[] interfaces = t.GetInterfaces();
			Console.WriteLine("Implemented Interfaces");
			foreach (Type type in interfaces)
			{
				Console.WriteLine("Interface : {0}", type.FullName);
				if (type.IsPublic)
				Console.WriteLine("Scope: Public");
				else
				Console.WriteLine("Scope: Private");
			}
		}
		public static void ShowEvents(Type t)
		{
			EventInfo[] events = t.GetEvents();
			Console.WriteLine("Implemented Events");
			foreach (EventInfo e in events)
			{
				Console.WriteLine("Event name: {0}", e.Name);
				Console.WriteLine("Multicast: {0}", 
				e.IsMulticast ? "Yes" : "No");
				Console.WriteLine("Member Type {0}",
				e.MemberType.ToString());
			}
		}
		public static void ShowTypes(string name, Assembly assembly)
		{
			Type[] typeArray = assembly.GetTypes();

			Console.WriteLine("Assembly Name: {0}", name);
			foreach (Type type in typeArray)
			{
				if (type.IsClass) {
					Console.WriteLine("\nNamespace : {0}",
					type.Namespace);
					Console.WriteLine("Class : {0}",
					type.FullName);
					if (type.BaseType != null)
					Console.WriteLine("Base Class : {0}",
					type.BaseType.FullName);
					else
					Console.WriteLine("Class not derived from anything");

					// Check if abstract
					if (type.IsAbstract)
					Console.WriteLine("Abstract base class");
					else
					Console.WriteLine("Instantiable class");
					if (type.IsPublic)
					Console.WriteLine("Scope: Public");
					else
					Console.WriteLine("Scope: Private");
					ShowInterfaces(type);
					ShowEvents(type);
				}
				else
				if (type.IsInterface)
				{
					Console.WriteLine("\nNamespace : {0}",
					type.Namespace);
					Console.WriteLine("Interface : {0}",
					type.FullName);
					if (type.IsPublic)
					Console.WriteLine("Scope: Public");
					else
					Console.WriteLine("Scope: Private");
				}
				else
				if (type.IsEnum)
				{
					Console.WriteLine("\nEnumeration: {0}",
					type.FullName);
				}
				else
				Console.WriteLine("\nType: {0}", type.FullName);
			}
		}
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                // Get the assemble object (from System.Reflection)
                Assembly assembly = Assembly.LoadFrom(args[0]);
                ShowTypes(args[0], assembly);
            }
        }
    }
}
