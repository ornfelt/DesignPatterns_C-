using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResp
{
    /// <summary>
    /// Chain of Responsibility Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);
            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p);
            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);
            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
            // Wait for user
            Console.ReadKey();
        }
    }
}
