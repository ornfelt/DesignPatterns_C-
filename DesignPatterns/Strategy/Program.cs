using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Strategy Design Pattern
    /// </summary>

    /**
    * The Strategy design pattern defines a family of algorithms, encapsulate each one, and make them interchangeable.
    * This pattern lets the algorithm vary independently from clients that use it.
    *
    * Strategy  (SortStrategy) declares an interface common to all supported algorithms. 
    * Context uses this interface to call the algorithm defined by a ConcreteStrategy.
    * ConcreteStrategy  (QuickSort, ShellSort, MergeSort) implements the algorithm using the Strategy interface
    * Context  (SortedList) is configured with a ConcreteStrategy object. Maintains a reference to a Strategy object. 
    * May define an interface that lets Strategy access its data.
     */

    public class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            // Context following different strategies
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            // Wait for user
            Console.ReadKey();
        }
    }
}
