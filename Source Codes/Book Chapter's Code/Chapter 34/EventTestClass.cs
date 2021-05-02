using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EventTestClass
{
    public enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
    public struct _SYSTEM_INFO
    {
        public int dwOemID;
        public int dwPageSize;
        public int lpMinimumApplicationAddress;
        public int lpMaximumApplicationAddress;
        public int dwActiveProcessorMask;
        public int dwNumberOfProcessors;
        public int dwProcessorType;
        public int dwAllocationGranularity;
        public short wProcessorLevel;
        public short wProcessorRevision;
    }
    public interface Channel
    {
        void Next();
        void Previous();
    }
    public class TestIntf : Channel
    {
        public void Next()
        {
            Console.WriteLine("Channel Next");
        }
        public void Previous()
        {
            Console.WriteLine("Previous");
        }
    }
    class EventTestClass
    {
        // The value to track
        private int nValue;

        // Allow a handler for the event
        public delegate Boolean ValueChangedEventHandler(int nValue);

        // This is the event itself
        public event ValueChangedEventHandler Changed;

        // This method is used to fire the event    
        protected virtual Boolean OnChanged(int nV)
        {
            return true;
        }
        public EventTestClass(int nValue)
        {
            SetValue(nValue);
        }
        public void SetValue(int nV)
        {
            if (nValue != nV)
            {
                if (OnChanged(nV))
                    nValue = nV;
                // Fire the event
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
