using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AccessingInterface
{
    public interface Channel
    {
        void Next();
        void Previous();
    }
    public interface Book
    {
        void Next();
        void Chapter();
    }
    class Program : Channel, Book // Implementing Interface in a class 
    {
        void Channel.Next()
        {
            Console.WriteLine("Channel Next");
        }
        void Book.Next()
        {
            Console.WriteLine("Book Next");
        }
        public void Previous()
        {
            Console.WriteLine("Previous");
        }
        public void Chapter()
        {
            Console.WriteLine("Chapter");
        }
        static void Main(string[] args)
        {
            Program app = new Program();
            ((Book)app).Next();
            app.Previous();
            app.Chapter();
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
