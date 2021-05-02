using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStringIndexer
{
    class Book
    {
        private string fTitle;
        private string fAuthor;
        private string fSubject;
        private string fDescription;
        public Book(string title, string author, string subj, string descr)
        {
            fTitle = title;
            fAuthor = author;
            fSubject = subj;
            fDescription = descr;
        }
        public Book() { }
        // Define a string indexer.
        public string this[string index]
        {
            get
            {
                if (index == "Title")
                    return fTitle;
                if (index == "Author")
                    return fAuthor;
                if (index == "Subject")
                    return fSubject;
                if (index == "Description")
                    return fDescription;
                return "Unknown";
            }
            set
            {
                if (index == "Title")
                    fTitle = value;
                if (index == "Author")
                    fAuthor = value;
                if (index == "Subject")
                    fSubject = value;
                if (index == "Description")
                    fDescription = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("C# Black Book", "Matt Telles",
            "C# programming", "A great book");
            Console.WriteLine("Book Title: {0}", b["Title"]);
            Book b2 = new Book();
            b2["Title"] = "Java Black Book";
            Console.WriteLine("Book Title: {0}", b2["Title"]);
            Console.Write("\nPress Enter to quit...");
            Console.ReadLine();
        }
    }
}
