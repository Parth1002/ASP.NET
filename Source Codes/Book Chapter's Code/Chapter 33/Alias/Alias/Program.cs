using System;
using System.Collections.Generic;
using System.Text;
using CmpDb = Alias.Database.Table;

namespace Alias
{
    public class DBInterface
    {
        public static void Open()
        {
            System.Console.WriteLine("Opening database");
        }
    }
    // Define a nested namespace within InternalClasses
    namespace Database
    {
        public class Table
        {
            public static void Open(string tblName)
            {
                System.Console.WriteLine("Opening table {0}",
                tblName);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CmpDb.Open("fred");
            Console.ReadLine();

        }
    }
}
