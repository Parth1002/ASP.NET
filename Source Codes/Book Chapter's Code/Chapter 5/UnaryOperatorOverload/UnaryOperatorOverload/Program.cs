using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnaryOperatorOverload
{
    class UnaryOperator
    {
        private int Number1;
        private int Number2;
        public UnaryOperator()
        {
        }
        public UnaryOperator(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void ShowData()
        {
            Console.WriteLine("The Numbers are: " + Number1 + " and " + Number2);
            ;
        }
        public static UnaryOperator operator -(UnaryOperator opr)
        {
            UnaryOperator obj = new UnaryOperator();
            obj.Number1 = -opr.Number1;
            obj.Number2 = -opr.Number2;
            return obj;
        }
    }
    class MainClass
    {
        public static void Main()
        {
            UnaryOperator opr1 = new UnaryOperator(20, 30);
            Console.WriteLine("Before Operator Overloading");
            opr1.ShowData();
            UnaryOperator opr2 = new UnaryOperator();
            opr2 = -opr1;
            Console.WriteLine("---------------------------");
            Console.WriteLine("After Operator Overloading");
            opr2.ShowData();
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
