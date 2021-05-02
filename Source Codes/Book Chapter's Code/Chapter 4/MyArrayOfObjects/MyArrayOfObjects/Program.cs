using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Size = 3;
            Employee[] Manager = new Employee[Size];
            for (int i = 0; i < Size; i++)
            {
                Manager[i] = new Employee();
            }
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Details of Manager:" + (i + 1));
                Manager[i].GetData();
                Console.WriteLine("--------------------");
            }
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Manager:" + (i + 1));
                Manager[i].PutData();
                Console.WriteLine("-------------");
            }

            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }

    }
    class Employee
    {
        string Name;
        float Age;
        public void GetData()
        {
            Console.Write("Enter Name :");
            Name = (Console.ReadLine());
            Console.Write("Enter Age:");
            Age = float.Parse(Console.ReadLine());
        }
        public void PutData()
        {
            Console.WriteLine("The Name is:" + Name);
            Console.WriteLine("The Age is:" + Age);
        }
    }
}
