using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new { Name = "Key Board", Price = 650 };
            Console.WriteLine("Product Details");
            Console.WriteLine("Name:" + product.Name);
            Console.WriteLine("Price: Rs." + product.Price);
            Console.Write("Press ENTER to quit...");
            Console.ReadLine();
        }
    }
}
