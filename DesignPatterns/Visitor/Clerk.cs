using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    // One of three employee types
    public class Clerk : Employee
    {
        // Constructor
        public Clerk()
            : base("Kevin", 25000.0, 14)
        {
        }
    }
}
