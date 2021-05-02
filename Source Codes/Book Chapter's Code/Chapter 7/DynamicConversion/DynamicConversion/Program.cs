using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicConversion
{
    class Program
    {
        dynamic dynDouble = 5.46;
        dynamic dynString = "test string";
        dynamic dynBool=true;
        dynamic dynDate = System.DateTime.Today;

        public void Method1()
        {
            // Printing the data type for dynamic type variables
            Console.WriteLine(dynDouble.GetType());
           Console.WriteLine(dynString.GetType());
           Console.WriteLine(dynBool.GetType());
           Console.WriteLine(dynDate.GetType());
        }

        public void Method2()
        {
        // taking the values for different variables from respective dynamic variables
        double d = dynDouble;
        string str = dynString;
        bool check = dynBool;
        DateTime date = dynDate;
        
        //Printing the values 
        Console.WriteLine("\nDouble: "+ d);
        Console.WriteLine("String: "+str);
        Console.WriteLine("Boolean: "+check);
        Console.WriteLine("DateTime: "+date);
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Method1();
            p.Method2();
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to quit....");
            Console.Read();
        }

    }
}
