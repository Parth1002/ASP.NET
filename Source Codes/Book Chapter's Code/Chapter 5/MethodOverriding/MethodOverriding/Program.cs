using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.setAge(18);
            AdultPerson ap = new AdultPerson();
            ap.setAge(18);
            Console.WriteLine("Person Age: {0}", p.getAge());
            Console.WriteLine("AdultPerson Age: {0}", ap.getAge());
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
    public class Person
    {
        private int fAge;
        public Person()
        {
            fAge = 21;
        }
        public virtual void setAge(int age)
        {
            fAge = age;
        }
        public virtual int getAge()
        {
            return fAge;
        }
    }
    public class AdultPerson : Person
    {
        public AdultPerson() { }
        override public void setAge(int age)
        {
            if (age > 21)
                base.setAge(age);
        }
    }
}
