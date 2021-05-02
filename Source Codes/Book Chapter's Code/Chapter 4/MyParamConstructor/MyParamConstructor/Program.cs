using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyParamConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            MySampleClass Obj1 = new MySampleClass();//No Parameter
            MySampleClass Obj2 = new MySampleClass("Martin");// One Parameter
            MySampleClass Obj3 = new MySampleClass("Martin", 26);//Two Parameters
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }
    public class MySampleClass
    {
        public MySampleClass()//Constructor without Parameter
        {

        }
        public MySampleClass(String Name)//Constructor with One Parameter
        {
            Console.WriteLine("Name is:" + Name);
            Console.WriteLine("--------------");
        }
        public MySampleClass(String Name, int Age)//Constructor with two Parameters
        {
            Console.WriteLine("Name is:" + Name);
            Console.WriteLine("Age is:" + Age);
        }
    }
}
