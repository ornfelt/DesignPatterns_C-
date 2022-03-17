using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{
    class ContractArray : IArray
    {
        private object[] array = new object[50];
        public object this[int index] { get => array[index]; set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            array[index] = value;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
