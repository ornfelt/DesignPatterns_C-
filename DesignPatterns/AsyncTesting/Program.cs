using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace DesignPatterns.AsyncTesting
{
    // From: https://www.youtube.com/watch?v=2moh18sh5p4
    class Program
    {
        //public static void Main(String[] args)
        public static void Old(String[] args)
        {
            // Good example of how prints are handled when working asynchronously
            Console.WriteLine("Start");
            AsyncTesting testing = new AsyncTesting();
            testing.ExecuteAsync_Click();
            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
}
