using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypeStructural
{
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id)
            : base(id)
        {
        }
        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
