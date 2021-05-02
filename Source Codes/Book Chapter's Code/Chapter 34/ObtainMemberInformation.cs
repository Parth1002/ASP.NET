using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace ObtainMemberInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            ShowClasses(args[0]);
            Console.ReadLine();
        }
        public static void ShowMethods(Type t)
        {
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine("\nMethod Name: {0}", m.Name);
                Console.WriteLine("Return Type: {0}", m.ReturnType);
            }
        }
        public static void ShowProperties(Type t)
        {
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo p in props)
            {
                Console.WriteLine("\nProperty Name: {0}", p.Name);
                Console.WriteLine("Type: {0}", p.MemberType);
            }
        }
        public static void ShowClasses(string name)
        {
            Assembly assembly = Assembly.LoadFrom(name);
            if (assembly != null)
            {
                // Get the classes from the assembly
                Type[] typeArray = assembly.GetTypes();

                Console.WriteLine("Assembly Name: {0}", name);
                foreach (Type type in typeArray)
                {
                    if (type.IsClass)
                    {
                        Console.WriteLine("Class: {0}", type.FullName);
                        ShowMethods(type);
                        ShowProperties(type);
                    }
                }
            }	
        }
    }
}
