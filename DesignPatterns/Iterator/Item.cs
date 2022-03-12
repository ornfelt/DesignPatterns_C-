using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    /// <summary>
    /// A collection item
    /// </summary>
    public class Item
    {
        string name;
        // Constructor
        public Item(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
