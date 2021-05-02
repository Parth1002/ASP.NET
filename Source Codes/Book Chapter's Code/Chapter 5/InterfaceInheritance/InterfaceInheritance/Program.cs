using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceInheritance
{
    interface BaseInterface
    {
        void GetPersonalDetail();
        void GetContactDetail();
    }
    interface DerivedInterface : BaseInterface
    {
        void ShowDetail();
    }
    class InterfaceImplementer : DerivedInterface
    {
        string Name;
        int Age;
        string Address;
        long PhoneNumber;
        public void GetPersonalDetail()
        {
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            Age = int.Parse(Console.ReadLine());
        }
        public void GetContactDetail()
        {
            Console.Write("Enter Your Address:");
            Address = Console.ReadLine();
            Console.Write("Enter Your Phone Number:");
            PhoneNumber = long.Parse(Console.ReadLine());
        }
        public void ShowDetail()
        {
            Console.WriteLine("");
            Console.WriteLine("Your Details are:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            InterfaceImplementer MyObj = new InterfaceImplementer();
            MyObj.GetPersonalDetail();
            MyObj.GetContactDetail();
            MyObj.ShowDetail();
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
