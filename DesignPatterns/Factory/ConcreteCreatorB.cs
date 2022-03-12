using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
