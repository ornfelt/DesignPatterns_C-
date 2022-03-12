﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));
            // Wait for user
            Console.ReadKey();
        }
    }
}
