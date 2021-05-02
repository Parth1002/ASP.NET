using System;
using System.Collections.Generic;
using System.Text;

namespace AliasClass
{
    class Program
    {
        public class System
        {
            public void Print()
            {
                global::System.Console.WriteLine("This is an example of :: operator");
            }
        }

        // Define a constant 'Console'
        const string Console = "Hello";
        const string str1 = "World";


        static void Main(string[] args)
        {
            // Error Accesses TestApp.Console
            System sys = new System();
            sys.Print();
            global::System.Console.WriteLine(Console);
            global::System.Console.WriteLine(str1);
            global::System.Console.ReadLine();


        }
    }
}
