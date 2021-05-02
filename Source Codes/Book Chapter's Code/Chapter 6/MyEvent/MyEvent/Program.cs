using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyEvent
{
    public class EventTestClass
    {
        // The value to track
        private int nValue;
        // Allow a handler for the event
        public delegate void ValueChangedEventHandler();
        // This is the event itself
        public event ValueChangedEventHandler Changed;
        // This method is used to fire the event     
        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed();
            else
                Console.WriteLine("Event fired. No handler!");
        }
        public EventTestClass(int nValue) { SetValue(nValue); }
        public void SetValue(int nV)
        {
            if (nValue != nV)
            {
                nValue = nV;
                // Fire the event
                OnChanged();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventTestClass etc = new EventTestClass(3);
            etc.SetValue(5);
            etc.SetValue(5);
            etc.SetValue(3);
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
