using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class President : Employee
    {
        // Constructor
        public President()
            : base("Eric", 45000.0, 21)
        {
        }
    }
}
