using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Drawing;

namespace SharedObject
{
    public delegate void StrokeEvent(Point from, Point till);
    public delegate void StatusEvent(string msg);
    [Serializable()]
    public class SharedObject : MarshalByRefObject
    {
        private static int Count = 0;
        public event StatusEvent Status;
        public event StrokeEvent Stroke;
        public SharedObject()
        {
            Count += 1;
        }
        public int GetCount()
        {
            return Count;
        }
        public void Greeting(string name)
        {
            System.Diagnostics.Debug.Write("SharedObject says Hi: " + name);
            if (Status != null)
                Status("SharedObject says Hi : " + name);
        }
        public void Confer(Point from, Point Till)
        {
            if (Stroke != null)
                Stroke(from, Till);
        }
        [OneWay()]
        public void ClimbTheCliff()
        {
            System.Diagnostics.Debug.WriteLine("Climbing the cliff, see you later.");
            System.Threading.Thread.Sleep(1000);
            System.Diagnostics.Debug.WriteLine("I am back.");
        }
        public override object InitializeLifetimeService()
        {
            ILease myLease = (ILease)base.InitializeLifetimeService();
            myLease.InitialLeaseTime = TimeSpan.FromMinutes(10);
            myLease.RenewOnCallTime = TimeSpan.FromMinutes(50);
            return myLease;
        }
    }
    public class EventSink : MarshalByRefObject
    {
        private StrokeEvent DrawLineMethod;
        private StatusEvent StatusMethod;

        public void OnStroke(Point from, Point Till)
        {
            DrawLineMethod(from, Till);
        }

        public void OnStatus(string msg)
        {
            StatusMethod("Calling Back : " + msg);
        }

        public EventSink(StrokeEvent DrSub)
        {
            DrawLineMethod = DrSub;
        }

        public EventSink(StatusEvent StSub)
        {
            StatusMethod = StSub;
        }

        public EventSink(StrokeEvent DrSub, StatusEvent StSub)
        {
            DrawLineMethod = DrSub;
            StatusMethod = StSub;
        }

    }
}
