using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
