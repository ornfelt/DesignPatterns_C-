using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{
    public class Employee 
    {
        public string name;
        int salary;
        public Employee () {}
        public Employee (string s) { name = s; }
        public string GetName() { return name; }
        public virtual int GetSalary()
        { return 10000; }
    }
}
