using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandRealWorld
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
