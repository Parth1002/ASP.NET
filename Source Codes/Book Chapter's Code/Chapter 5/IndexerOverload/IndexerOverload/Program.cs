using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerOverload
{
    class MyClass
    {
        private string[] MyData;
        private int ArraySize;
        public MyClass(int size)
        {
            ArraySize = size;
            MyData = new string[size];
            for (int i = 0; i < size; i++)
            {
                MyData[i] = "DataValue";
            }
        }
        public string this[int Position]
        {
            get
            {
                return MyData[Position];
            }
            set
            {
                MyData[Position] = value;
            }
        }
        public string this[string data]
        {
            get
            {
                int Count = 0;
                for (int i = 0; i < ArraySize; i++)
                {
                    if (MyData[i] == data)
                    {
                        Count = Count + 1;
                    }
                }
                return Count.ToString();
            }
            set
            {
                for (int i = 0; i < ArraySize; i++)
                {
                    if (MyData[i] == data)
                    {
                        MyData[i] = value;
                    }
                }
            }
        }
        class MainClass
        {
            static void Main(string[] args)
            {
                int size = 10;
                MyClass MyIndexer = new MyClass(size);
                MyIndexer[9] = "Hello";
                MyIndexer[3] = "Welcome";
                MyIndexer[5] = "Good Morning";
                MyIndexer[7] = "Good Night";
                MyIndexer["DataValue"] = "Have a Nice Day";
                Console.WriteLine("\nIndexer Output\n");
                Console.WriteLine("-----------------");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("MyIndexer[{0}]: {1}", i, MyIndexer[i]);
                }
                Console.WriteLine("\nNumber of \"Have a Nice Day\" Entries: {0}",
                MyIndexer["Have a Nice Day"]);
                Console.Write("\nPress ENTER to quit...");
                Console.ReadLine();
            }
        }
    }
}
