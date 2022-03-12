using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterSecond
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
