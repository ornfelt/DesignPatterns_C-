﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Create math proxy
            MathProxy proxy = new MathProxy();
            // Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
            // Wait for user
            Console.ReadKey();
        }
    }
}
