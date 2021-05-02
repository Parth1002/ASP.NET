using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperation
{
    public class ArithmeticOperation : System.MarshalByRefObject
    {
        int result;
        public ArithmeticOperation()
        {
            Console.WriteLine("Math operation started.");
        }
        public string Add(int num1, int num2)
        {
            result = num1 + num2;
            return "Addition of a and b : " + result.ToString();
        }
        public string Subtract(int num1, int num2)
        {
            result = num1 - num2;
            return "Subtraction of a and b : " + result.ToString();
        }
        public string Multiply(int num1, int num2)
        {
            result = num1 * num2;
            return "Multiplication of a and b : " + result.ToString();
        }
        public string Divide(int num1, int num2)
        {
            result = num1 / num2;
            return "Division of a and b : " + result.ToString();
        }
    }
}
