using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PointerToStruct
{
    struct MyStruct
    {
        public double Length;
        public double Breadth;
        public double Height;
        public void SetDimensions()
        {
            Console.Write("Enter Length of Room (in meter):");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Breadth of Room (in meter):");
            Breadth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Height of Room (in meter):");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public void ShowVolume()
        {
            double Volume = (Length * Breadth * Height);
            Console.WriteLine("The Volume of Room is: " + Volume + " cubic meter");
        }
    }
    class MainClass
    {
        public unsafe static void Main()
        {
            MyStruct mystruct = new MyStruct();
            MyStruct* mystruct1 = &mystruct;
            mystruct1->SetDimensions();
            mystruct1->ShowVolume();
            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to quit....");
            Console.Read();
        }
    }
}
