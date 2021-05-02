using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulating
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;  //Declaring a string variable
            string mname;  //Declaring a string variable
            string lname;  //Declaring a string variable
            Console.WriteLine("Enter your first name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your middle name");
            mname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lname = Console.ReadLine();

            string completename = fname + "\t" + mname + "\t" + lname; //Concatenating the string values
            Console.WriteLine("Your complete name is " + completename);
            Console.WriteLine("                                     ");

            Console.WriteLine("Your name in UPPERCASE is " + completename.ToUpper());//Converting to UPPERCASE
            Console.WriteLine("                                     ");
            Console.WriteLine("Enter the new first name with which you want to replace your previous first name");
            string newname = Console.ReadLine();

            Console.WriteLine("The new name is " + completename.Replace(fname, newname)); //Replacing string
            Console.ReadLine();

        }
    }
}
