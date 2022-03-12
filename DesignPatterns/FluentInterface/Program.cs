using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentInterface
{
    class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");
            
            Console.Read();
        }
    }
}
