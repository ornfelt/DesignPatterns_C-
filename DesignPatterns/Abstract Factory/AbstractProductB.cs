using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}
