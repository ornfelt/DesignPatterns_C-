#define CONTRACTS_FULL

using System;
using System.Diagnostics.Contracts;

namespace DesignPatterns.Testing
{
    // See https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts for more info

    // You can express preconditions by using the Contract.Requires method. Preconditions specify state when a method is invoked. 

    // Postconditions are contracts for the state of a method when it terminates. The postcondition is checked just before exiting a method.
    // You can express standard postconditions by using the Ensures method.
    // Postconditions express a condition that must be true upon normal termination of the method.

    // Object invariants are conditions that should be true for each instance of a class whenever that object is visible to a client.
    // They express the conditions under which the object is considered to be correct.
    //The invariant methods are identified by being marked with the ContractInvariantMethodAttribute attribute.
    // The invariant methods must contain no code except for a sequence of calls to the Invariant method,
    // each of which specifies an individual invariant.

    class ContractTesting
    {
        public static void StartContractTesting()
        {
            IArray array = new ContractArray();
            array.Insert(0, "test");
            Console.WriteLine(array[0]);
        }
    }
}
