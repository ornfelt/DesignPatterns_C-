using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject
{
    class Customer : ICustomer
    {
      public bool IsNull() 
      {
        return false;
      }

      public void GetPlan()
       {
            Console.WriteLine("Customer plan...");
       }
    }
}
