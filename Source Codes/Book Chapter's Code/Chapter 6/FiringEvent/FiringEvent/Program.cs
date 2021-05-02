using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate Boolean AccountEventHandler(object sender, double amt);
namespace FiringEvent
{
    public class Account
    {
        private double Total;
        public AccountEventHandler ah = null;
        public Account()
        {
            Total = 0;
        }
        public double getTotal()
        {
            return Total;
        }
        public void AddOnPost(AccountEventHandler handler)
        {
            ah = (AccountEventHandler)Delegate.Combine(ah, handler);
        }
        public void RemoveOnPost(AccountEventHandler handler)
        {
            ah = (AccountEventHandler)Delegate.Remove(ah, handler);
        }
        public Boolean OnPost(double amt)
        {
            if (ah != null)
                return ah(this, amt);
            return true;
        }
        public void PostDebit(double amt)
        {
            // Fire the event, checking to see if the return is ok
            Boolean okToSubtract = OnPost(amt);
            if (okToSubtract)
            {
                Console.WriteLine("Debit ok!");
                Total -= amt;
            }
            else
            {
                Console.WriteLine("Debit NOT ok! Not posting");
            }
        }
        public void PostCredit(double amt)
        {
            Total += amt;
        }
    }
    class Program
    {
        public static Boolean CheckPost(object o, double d)
        {
            // See if it went negative
            Account a = (Account)o;
            if (d > a.getTotal())
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Account a = new Account();
            AccountEventHandler evh = new
            AccountEventHandler(CheckPost);
            a.AddOnPost(evh);
            // Can we debit 100?
            if (a.OnPost(100.00))
                a.PostDebit(100.00);
            else
                Console.WriteLine("Cannot debit 100.0");
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
