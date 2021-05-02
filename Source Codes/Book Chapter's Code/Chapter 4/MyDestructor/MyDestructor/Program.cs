using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Destruct obj = new Destruct();

        }
    }
    class Destruct
    {
        ~Destruct()
        {
            Console.WriteLine("Destructor is Called");
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }

    }
}
