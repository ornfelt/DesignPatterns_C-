using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{
    public class Secretary : Employee 
    {
        public Secretary (string s) { name = s; }
        public override int GetSalary() { return 15000; }
    }
}
