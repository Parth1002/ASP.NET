using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
    class DumpParameterandMethod
    {
        public static void DumpParameters(ParameterInfo[] pars)
        {
            // Dump them out
            foreach (ParameterInfo pi in pars) {
                Console.WriteLine("\n   Parameter Name: {0}",
                pi.Name);
                Console.WriteLine("   Parameter Type: {0}",
                pi.ParameterType);
                Console.WriteLine("   Is In? {0}",
                pi.IsIn);
                Console.WriteLine("   Is Out? {0}",
                pi.IsOut);
            }
        }
        public static void DumpType(Type t)
        {
            // Dump the constructors
            ConstructorInfo[] cons = t.GetConstructors();
            foreach (ConstructorInfo ci in cons)
            {
                // Get all the parameters
                ParameterInfo[] pars = ci.GetParameters();
                Console.WriteLine("\nConstructor: {0}", ci.Name);
                DumpParameters(pars);
            }
            // Dump each method
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine("\nMethod: {0}", m.Name);
                Console.WriteLine("Return Type: {0}", m.ReturnType);
                // Get all the parameters
                ParameterInfo[] pars = m.GetParameters();
                // Dump the parameters
                DumpParameters(pars);
            }
        }
        public static void ShowType(string assemblyName,
        string className)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyName);
            if (assembly == null)
                return;
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                // Only classes
                if (t.IsClass == false)
                    continue;
                // Only the one we want
                string Name = (string)t.FullName;
                if (Name != className)
                    continue;
                // Okay, this is it, dump it
                DumpType(t);
            }
        }
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            ShowType(args[0], args[1]);            
        }
    }
