using System;
using System.Collections.Generic;
using System.Text;

namespace TypeMaxandMin
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, print out the minimum values
            Console.WriteLine("System Minimums\n");
            Console.WriteLine("MinSByte {0}", System.SByte.MinValue);
            Console.WriteLine("MinByte {0}", System.Byte.MinValue);
            Console.WriteLine("MinInt16 {0}", System.Int16.MinValue);
            Console.WriteLine("MinUInt16 {0}", System.UInt16.MinValue);
            Console.WriteLine("MinInt32 {0}", System.Int32.MinValue);
            Console.WriteLine("MinUInt32 {0}", System.UInt32.MinValue);
            Console.WriteLine("MinInt64 {0}", System.Int64.MinValue);
            Console.WriteLine("MinUInt64 {0}", System.UInt64.MinValue);
            Console.WriteLine("MinChar {0}", System.Char.MinValue);
            Console.WriteLine("MinSingle {0}", System.Single.MinValue);
            Console.WriteLine("MinDouble {0}", System.Double.MinValue);
            Console.WriteLine("MinDecimal {0}", System.Decimal.MinValue);
            Console.WriteLine("\nSystem Maximums\n");
            Console.WriteLine("MaxSByte {0}", System.SByte.MaxValue);
            Console.WriteLine("MaxByte {0}", System.Byte.MaxValue);
            Console.WriteLine("MaxInt16 {0}", System.Int16.MaxValue);
            Console.WriteLine("MaxUInt16 {0}", System.UInt16.MaxValue);
            Console.WriteLine("MaxInt32 {0}", System.Int32.MaxValue);
            Console.WriteLine("MaxUInt32 {0}", System.UInt32.MaxValue);
            Console.WriteLine("MaxInt64 {0}", System.Int64.MaxValue);
            Console.WriteLine("MaxUInt64 {0}", System.UInt64.MaxValue);
            Console.WriteLine("MaxChar {0}", System.Char.MaxValue);
            Console.WriteLine("MaxSingle {0}", System.Single.MaxValue);
            Console.WriteLine("MaxDouble {0}", System.Double.MaxValue);
            Console.WriteLine("MaxDecimal {0}", System.Decimal.MaxValue);
            Console.ReadLine();

        }
    }
}
