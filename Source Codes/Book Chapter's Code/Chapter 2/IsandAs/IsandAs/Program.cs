using System;
using System.Collections.Generic;
using System.Text;

namespace IsandAs
{
    class Program
    {
        static void Main(string[] args)
        {
            object i = 25;
            object str = "Kogent Learning Solutions";
            if (i is string)                //Checking compatibility
                Console.WriteLine("i is a string type");
            else
                Console.WriteLine("i is an integer type");
            string str1 = i as string;      //Casting i to string
            string str2 = str as string;    //Casting str to string
            Console.WriteLine("The value of str1 is " + str1);
            Console.WriteLine("The value of str2 is " + str2);
            Console.ReadLine();

        }
    }
}
