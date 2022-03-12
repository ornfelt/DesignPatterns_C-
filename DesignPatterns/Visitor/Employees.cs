﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    public class Employees
    {
        private List<Employee> employees = new List<Employee>();
        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }
        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
