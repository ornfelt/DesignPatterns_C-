using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
