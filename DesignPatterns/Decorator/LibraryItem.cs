using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class LibraryItem
    {
        private int numCopies;
        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }
        public abstract void Display();
    }
}
