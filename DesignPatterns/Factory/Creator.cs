using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
