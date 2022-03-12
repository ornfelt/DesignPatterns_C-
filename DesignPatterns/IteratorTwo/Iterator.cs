using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorTwo
{
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

}
