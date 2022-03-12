using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorTwo
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        // Get item count
        public int Count
        {
            get { return items.Count; }
        }
        // Indexer
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
