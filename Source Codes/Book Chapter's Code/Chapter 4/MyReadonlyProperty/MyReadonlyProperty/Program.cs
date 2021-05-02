using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyReadonlyProperty
{
    public class PropertyHolder
    {
        private int someProperty = 0;

        public PropertyHolder(int propVal)
        {
            someProperty = propVal;
        }

        public int SomeProperty
        {
            get
            {
                return someProperty;
            }
        }
    }

    public class PropertyTester
    {
        public static void Main(string[] args)
        {
            PropertyHolder propHold = new PropertyHolder(5);

            Console.WriteLine("Property Value: " + propHold.SomeProperty);
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }
}
