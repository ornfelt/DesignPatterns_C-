using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject
{
    class Program
    {
        //public static void Main(String[] args)
        public static void Old(String[] args)
        {
            String CustomerType = "Normal";
            ICustomer customer;
            // Could also set the Null-object here already
            //ICustomer customer = new NullCustomer();

            switch (CustomerType)
            {
                case "Normal":
                    customer = new Customer();
                    break;
                default:
                    // Default is Null-object
                    customer = new NullCustomer();
                    break;
            }
            // Use Null-object as if it's normal subclass
            customer.GetPlan();
        }
    }
}
