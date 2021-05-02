using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PointerToArray
{
    class MyClass
    {
        public unsafe void MyMethod()
        {
            int[] MyArray = new int[10];
            for (int Counter = 0; Counter < 10; Counter++)
            {
                MyArray[Counter] = Counter * Counter;
            }
            fixed (int* Mypointer = MyArray)
                ShowData(Mypointer);
        }
        public unsafe void ShowData(int* ptr)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(*(ptr + i));
            }
        }
    }
    class MainClass
    {
        public static void Main()
        {
            MyClass myclass = new MyClass();
            myclass.MyMethod();
            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to quit....");
            Console.Read();

        }
    }
}
