using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
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
