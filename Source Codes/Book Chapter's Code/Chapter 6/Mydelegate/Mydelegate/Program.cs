using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Mydelegate
{
    public class Account
    {
        private string Name;
        private string Address;
        private double Balance;
        public Account(string n, string a)
        {
            Name = n;
            Address = a;
            Balance = 0.0;
        }
        public void AddToBalance(double amount)
        {
            Balance += amount;
        }
        public void RemoveFromBalance(double amount)
        {
            Balance -= amount;
        }
        public string getName()
        {
            return Name;
        }

        public string getAddress()
        {
            return Address;
        }
        public double getBalance()
        {
            return Balance;
        }
    }
    public class AccountHandler
    {
        public AccountHandler() { }
        public Boolean AccountInc(Account a, double amt)
        {
            a.AddToBalance(amt);
            return true;
        }
        public Boolean AccountDec(Account a, double amt)
        {
            a.RemoveFromBalance(amt);
            return true;
        }
    }
    public class AccountDB
    {
        Account[] accounts;
        int nNumAccounts;

        // Declare delegates
        public delegate Boolean IncrementAccountDelegate(Account a,
        double d);
        public delegate Boolean DecrementAccountDelegate(Account a,
        double d);
        public AccountDB()
        {
            accounts = new Account[10];
            nNumAccounts = 0;
        }

        // A method to create a new account   
        public void AddAccount(string n, string a)
        {
            accounts[nNumAccounts++] = new Account(n, a);
        }
        public void PostToAccount(int nAcct, double d,
        IncrementAccountDelegate inc,
        DecrementAccountDelegate dec)
        {
            if (d < 0)
                dec(accounts[nAcct], -d);
            else
                inc(accounts[nAcct], d);
        }
        public void PrintAccountStatus()
        {
            for (int i = 0; i < nNumAccounts; ++i)
            {
                Console.WriteLine("Name: {0} \nAddress: {1} \nBalance: {2}",
                accounts[i].getName(), accounts[i].getAddress(),
                accounts[i].getBalance());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AccountHandler ah = new AccountHandler();
            AccountDB adb = new AccountDB();
            // Add two accounts
            adb.AddAccount("Jyoti", "224, Shipra Suncity, Ghaziabad");
            adb.AddAccount("Amitabh Kumar", "501, Kalkaji, Delhi");

            // Create the delegates
            AccountDB.IncrementAccountDelegate iad =
            new AccountDB.IncrementAccountDelegate(ah.AccountInc);
            AccountDB.DecrementAccountDelegate dad =
            new AccountDB.DecrementAccountDelegate(ah.AccountDec);
            // Okay, add some stuff and decrement it
            adb.PostToAccount(0, 100.00, iad, dad);
            adb.PostToAccount(0, 200.00, iad, dad);
            adb.PostToAccount(0, -50.00, iad, dad);
            adb.PostToAccount(1, 500.00, iad, dad);
            adb.PostToAccount(1, 300.00, iad, dad);
            adb.PostToAccount(1, -150.00, iad, dad);
            // Print out the totals
            adb.PrintAccountStatus();
            Console.Write("\nPress ENTER to quit...");
            Console.ReadLine();
        }
    }
}
