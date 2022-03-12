using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Open a new account
            Account account = new Account("Jim Johnson");
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            // Wait for user
            Console.ReadKey();
        }
    }
}
