using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PointerToPointer
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            char FirstChar;
            char* SecondChar;
            char** ThirdChar;
            FirstChar = 'S';
            SecondChar = &FirstChar;
            ThirdChar = &SecondChar;
            Console.WriteLine("The value of FirstChar is: " + FirstChar);
            Console.WriteLine("The Value of SecondChar is: {0}", (int)SecondChar);
            Console.WriteLine("The Value of ThirdChar is: {0}", (int)ThirdChar);
            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to quit....");
            Console.Read();
        }
    }
}

