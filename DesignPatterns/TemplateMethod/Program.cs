using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    // This real-world code demonstrates a Template method named Run() which provides a skeleton calling sequence of methods.
    // Implementation of these steps are deferred to the CustomerDataObject subclass which implements the
    // Connect, Select, Process, and Disconnect methods. 

    /// <summary>
    /// Template Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}
