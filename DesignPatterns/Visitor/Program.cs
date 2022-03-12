using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Setup employee collection
            Employees employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());
            // Employees are 'visited'
            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());
            // Wait for user
            Console.ReadKey();
        }
    }
}
