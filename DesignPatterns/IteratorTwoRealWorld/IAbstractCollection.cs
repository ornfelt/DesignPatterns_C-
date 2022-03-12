using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorTwoRealWorld
{
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
