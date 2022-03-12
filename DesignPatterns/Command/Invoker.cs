using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Invoker
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
