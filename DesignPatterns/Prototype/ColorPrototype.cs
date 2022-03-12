using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
