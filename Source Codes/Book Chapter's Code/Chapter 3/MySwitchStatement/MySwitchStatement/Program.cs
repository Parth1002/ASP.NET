using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Marks;
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Select the Range of Marks:");
            Console.WriteLine("1.   0-20");
            Console.WriteLine("2.   21-40");
            Console.WriteLine("3.   41-60");
            Console.WriteLine("4.   61-80");
            Console.WriteLine("5.   80-100");
            Console.Write("Enter Your Choice (1,2,3,4,5):");
            Marks = int.Parse(Console.ReadLine());
            switch (Marks)
            {
                case 1:
                    {
                        Console.Write(Name + " your marks are very Low.\n");
                    }
                    break;
                case 2:
                    {
                        Console.Write(Name + " your marks are Low. \n");
                    }
                    break;
                case 3:
                    {
                        Console.Write(Name + " your marks are Average.\n");
                    }
                    break;
                case 4:
                    {
                        Console.Write(Name + " your marks are Good.\n");
                    }
                    break;
                case 5:
                    {
                        Console.Write(Name + " your marks are very Good.\n");
                    }
                    break;
                default:
                    break;
            }
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();

        }
    }
}
