using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{
    public class Manager : Employee 
    {
        Secretary secretary;
        public Manager (string n, Secretary s)
        { name = n; secretary = s;}
        public int GetSalary() { return 25000; }
        public Secretary GetSecretary()
        { return secretary; }
    }
}
