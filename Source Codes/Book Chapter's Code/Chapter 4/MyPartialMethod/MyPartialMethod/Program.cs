using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPartialMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Acc = new Account();
            Acc.CalculateInterest();
            Acc.ShowInterest();
        }
    }
    partial class Account
    {
        double PrincipalAmount, InterestRate, Time, SimpleInterest;
        public void CalculateInterest()
        {
            Console.Write("Enter Principal Amount (P):");
            PrincipalAmount = double.Parse(Console.ReadLine());
            Console.Write("Enter Interest Rate (R):");
            InterestRate = double.Parse(Console.ReadLine());
            Console.Write("Enter Time Duration (T):");
            Time = double.Parse(Console.ReadLine());
        }
        partial void ShowAmount();
    }
    partial class Account
    {

        partial void ShowAmount()
        {
            double amount = PrincipalAmount + SimpleInterest;
            Console.WriteLine("Total Amount: " + amount);
        }
        public void ShowInterest()
        {
            SimpleInterest = (PrincipalAmount * InterestRate * Time) / 100;
            Console.WriteLine("SimpleInterest: " + SimpleInterest);
            ShowAmount();
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();
        }
    }
}
