using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorTwo
{
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
