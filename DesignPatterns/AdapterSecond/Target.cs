using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterSecond
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
