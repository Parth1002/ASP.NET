using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Amount Amt = new Amount();
            Amt.Balance();
            Amt.GetData();
            Console.Write("\nPress ENTER to Quit..");
            Console.ReadLine();

        }
        public class Amount
        {
            double TotalAmount = 12000, Deductions = 2000, BalanceAmount;
            public void Balance()
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
}