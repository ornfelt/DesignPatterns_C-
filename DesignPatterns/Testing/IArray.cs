#define CONTRACTS_FULL

using System;
using System.Diagnostics.Contracts;

namespace DesignPatterns.Testing
{
    // An IArray is an ordered collection of objects.
    [ContractClass(typeof(IArrayContract))]
    public interface IArray
    {
        // The Item property provides methods to read and edit entries in the array.
        Object this[int index]
        {
            get;
            set;
        }

        int Count
        {
            get;
        }

        // Adds an item to the list.
        // The return value is the position the new element was inserted in.
        int Add(Object value);

        // Removes all items from the list.
        void Clear();

        // Inserts value into the array at position index.
        // index must be non-negative and less than or equal to the
        // number of elements in the array.  If index equals the number
        // of items in the array, then value is appended to the end.
        void Insert(int index, Object value);

        // Removes the item at position index.
        void RemoveAt(int index);
    }
}
