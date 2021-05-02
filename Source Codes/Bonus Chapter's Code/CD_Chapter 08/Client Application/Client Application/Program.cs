using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.EnterpriseServices;

namespace Client_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Component.Component com = new Component.Component();
            Console.WriteLine("The addition of the two numbers is " + com.Add(10, 24));
            Console.ReadLine();
        }
    }
}
