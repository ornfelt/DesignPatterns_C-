using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorTwoRealWorld
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
