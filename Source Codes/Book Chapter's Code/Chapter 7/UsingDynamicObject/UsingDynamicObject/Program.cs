using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace UsingDynamicObject
{


    // The class derived from DynamicObject
    public class DynamicWord : DynamicObject
    {
        // The inner predefined dictionary, which repersents collection of keys and values

        Dictionary<string, object> dict = new Dictionary<string, object>();

        // This property returns the number of elements in the inner dictionary.
        public int Cnt
        {
            get
            {
                return dict.Count;
            }
        }

        // This method is called, when you try to get a value of a property not defined in the class. 
        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {
            // Converting the property name to lowercase so that it become case-insensitive.
            string name = binder.Name.ToLower();

            // Set the result parameter to the property value and return true, whenever property name is found in a dictionary
            //otherwise, return false.
            return dict.TryGetValue(name, out result);
        }

        // This method is called, when you try to set a value of a property not defined in the class.
        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            // Converting the property name to lowercase so that it become case-insensitive.
            dict[binder.Name.ToLower()] = value;

            // This method must always returns true, so that you can always add a value
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a dynamic dictionary.
            dynamic dyn = new DynamicWord();

            // Adding new dynamic properties to the object of the DynamicWord class.
            //Thus, the TrySetMember method is called, by default.
            dyn.Text = "C#";
            dyn.Description = "A programming language";

            // Getting the values of the dynamic properties. Thus the TryGetMember method is called by default.
            Console.WriteLine(dyn.text + "  " + dyn.description);

            // Getting the value of the Count property. 
            //The cnt property is defined in the class.
            //Thus the TryGetMember is not called.

            Console.WriteLine(
                "Number of dynamic properties:" + dyn.Cnt);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to quit....");
            Console.Read();

            // Console.WriteLine(dyn.definition);
            // The preceding statement throws an exception at run time.
            // There is no "definition" property,
            // so the GetMember method returns false and this causes a
            // RuntimeBinderException.

        }
    }
}

