using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyIndexer
{
    class List
    {
        string[] Name = new string[3];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Name.Length)
                {
                    return null;
                }
                else
                {
                    return (Name[index]);
                }
            }
            set
            {
                Name[index] = value;
            }
        }
    }
    class IndexerTest
    {
        public static void Main()
        {
            List list = new List();
            list[0] = "Umar";
            list[1] = "Charu";
            list[2] = "Jyoti";
            for (int i = 0; i <= 2; i++)
                Console.WriteLine(list[i]);
            Console.ReadLine();
            Console.Write("\nPress ENTER to quit...");
        }
    }
}

