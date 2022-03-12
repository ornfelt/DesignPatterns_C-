using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterSecond
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}
