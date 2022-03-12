using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class DataAccessor
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process(int top);
        public abstract void Disconnect();
        // The 'Template Method' 
        public void Run(int top)
        {
            Connect();
            Select();
            Process(top);
            Disconnect();
        }
    }
}
