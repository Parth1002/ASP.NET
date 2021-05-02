using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryOperatorOverload
{
    class BinaryOperator
    {
        private int Number1;
        private int Number2;
        public BinaryOperator()
        {
        }
        public BinaryOperator(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void ShowData()
        {
            Console.WriteLine("The Numbers are: " + Number1 + " and " + Number2);
        }
        public static BinaryOperator operator +(BinaryOperator opr1, BinaryOperator
        opr2)
        {
            BinaryOperator opr = new BinaryOperator();
            opr.Number1 = opr1.Number1 + opr2.Number1;
            opr.Number2 = opr1.Number2 + opr2.Number2;
            return opr;
        }
    }
    class MainClass
    {
        public static void Main()
        {
            BinaryOperator opr1 = new BinaryOperator(20, 30);
            opr1.ShowData(); // displays 20 & 30
            BinaryOperator opr2 = new BinaryOperator(30, 40);
            opr2.ShowData(); // displays 30 & 40
            BinaryOperator opr3 = new BinaryOperator();
            opr3 = opr1 + opr2;
            opr3.ShowData(); // dislplays 50 & 70
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
