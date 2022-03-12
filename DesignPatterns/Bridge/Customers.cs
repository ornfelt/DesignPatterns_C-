using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
