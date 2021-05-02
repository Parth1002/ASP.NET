using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicDataType
{
    class Program
    {
        static dynamic dyn = 5.56;
        public void Method1(string str, int b)
        {
        Console.WriteLine(str);
        Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //This method compiles and runs successfully. 
            p.Method1("Hello", 45);

            //The following lines compiles successfully but, shows an error at run time.
            //The value type of dynamic dyn variable is float.
            p.Method1("Hello", dyn); //an integer value is required as the second argument
          
            p.Method1(dyn, dyn); //a string and integer values are required as first and second arguments 
            Console.Read();
        }

    }
}

