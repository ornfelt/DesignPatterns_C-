using System;
using System.Collections.Generic;
using System.Text;

/**
 * The Command design pattern encapsulates a request as an object, thereby letting you parameterize clients with 
 * different requests,queue or log requests, and support undoable operations.
 *
 *  Command declares an interface for executing an operation.
 *  ConcreteCommand (CalculatorCommand) defines a binding between a Receiver object and an action.
 *  Client  (CommandApp) creates a ConcreteCommand object and sets its receiver.
 *  Invoker  (User) asks the command to carry out the request.
 *  Receiver  (Calculator) knows how to perform the operations associated with carrying out the request.
 */
namespace DesignPatterns.Command
{
    class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Structural code
            // Create receiver, command, and invoker 
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            // Wait for user
            Console.ReadKey();
        }
    }
}
