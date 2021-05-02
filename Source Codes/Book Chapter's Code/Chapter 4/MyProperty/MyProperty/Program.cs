using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProperty
{
    class Person
    {
        private string MyName = "";
        private int MyAge = 0;

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return MyName;
            }
            set
            {
                MyName = value;
            }
        }

        // Declare an Age property of type int:
        public int Age
        {
            get
            {
                return MyAge;
            }
            set
            {
                MyAge = value;
            }
        }

        public override string ToString()
        {
            return ("Name = " + Name + ", Age = " + Age);

        }

        public static void Main()
        {
            Console.WriteLine("Simple Properties");

            // Create a new Person object:
            Person person = new Person();

            // Print out the name and the age associated with the person:
            Console.WriteLine("Person details: " + person);

            // Set some values on the person object:
            person.Name = "Umar";
            person.Age = 24;
            Console.WriteLine("Person details: " + person);

            // Increment the Age property:
            person.Age += 1;
            Console.WriteLine("Person details: " + person);
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }
}
