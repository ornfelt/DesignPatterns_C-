using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorTwo
{

    /**
    * The Iterator design pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
    *
    * Iterator  (AbstractIterator) defines an interface for accessing and traversing elements.
    * ConcreteIterator  (Iterator) implements the Iterator interface. Keeps track of the current position in the traversal of the aggregate.
    * Aggregate  (AbstractCollection) defines an interface for creating an Iterator object.
    * ConcreteAggregate  (Collection) implements the Iterator creation interface to return an instance of the proper ConcreteIterator.
    */

    class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
            // Create Iterator and provide aggregate
            Iterator i = a.CreateIterator();
            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
