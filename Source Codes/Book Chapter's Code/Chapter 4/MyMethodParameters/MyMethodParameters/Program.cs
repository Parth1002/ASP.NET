using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Amount Amt = new Amount();
            Amt.Balance(12000, 2000);
            Amt.GetData();
            Console.Write("\nPress ENTER to quit..");
            Console.ReadLine();
        }
    }
    public class Amount
    {
        double TotalAmount, Deductions, BalanceAmount;
        public void Balance(double TotalAmount, double Deductions)
        {
            BalanceAmount = TotalAmount - Deductions;
            Console.WriteLine("Your Current Amount is Rs: " + BalanceAmount);

        }
        public void Debit()
        {
            int DebitAmount = 0;
            Console.Write("Enter Amount:");
            DebitAmount = int.Parse(Console.ReadLine());
            BalanceAmount = BalanceAmount - DebitAmount;
            Console.WriteLine("Your Balance Amount is Rs.:" + BalanceAmount);
        }
        public void Credit()
        {
            int CreditAmount = 0;
            Console.Write("Enter Amount:");
            CreditAmount = int.Parse(Console.ReadLine());
            BalanceAmount = BalanceAmount + CreditAmount;
            Console.WriteLine("Your Balance Amount is Rs.:" + BalanceAmount);
        }
        public void GetData()
        {
            char Data;
            Console.WriteLine("---------------------------------");
            Console.Write("Press (d) for Debit and (c) for Credit:");
            Data = char.Parse(Console.ReadLine());
            if (Data == 'd')
            {
                Debit();
            }
            if (Data == 'c')
            {
                Credit();
            }
        }
    }

}
