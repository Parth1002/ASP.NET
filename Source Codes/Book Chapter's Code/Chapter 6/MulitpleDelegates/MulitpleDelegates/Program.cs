using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MulitpleDelegates
{
    public class EventHandler1Class
    {
        public static void HandleEvent1(string s)
        {
            Console.WriteLine("EventHandler1::HandleEvent1 called [{0}]", s);
        }
    }
    public class EventHandler2Class
    {
        public static void HandleEvent1(string s)
        {
            Console.WriteLine("EventHandler2::HandleEvent1 called [{0}]", s);
        }
    }
    public class EventClass
    {
        public delegate void OnEventFired(string s);
        private string fS;
        public OnEventFired evf = null;
        public EventClass(string s)
        {
            fS = s;
            OnFireEvent();
        }
        public void setString(string s)
        {
            fS = s;
            OnFireEvent();
        }
        private void OnFireEvent()
        {
            // Just fire the event
            if (evf != null)
                evf(fS);
        }
        public void CallAllEventHandlers(string s)
        {
            if (evf == null)
                return;
            Delegate[] list = evf.GetInvocationList();
            for (int i = 0; i < list.Length; ++i)
            {
                OnEventFired oef = (OnEventFired)list[i];
                oef(s);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create the event handlers
            EventClass.OnEventFired ev1 = new
             EventClass.OnEventFired(EventHandler1Class.HandleEvent1);
            EventClass.OnEventFired ev2 = new
             EventClass.OnEventFired(EventHandler2Class.HandleEvent1);
            // Now, create an instance of the class
            EventClass e = new EventClass("Hello world");
            // Set up the handler
            e.evf = (EventClass.OnEventFired)Delegate.
            Combine(ev1, ev2);
            // Change something so that it is called
            e.setString("Hello!");
            // Now, call all the handlers
            e.CallAllEventHandlers("Goodbye!");
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
