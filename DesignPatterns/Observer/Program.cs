using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    /**
    Observer pattern:
    * Subject (Stock) who knows its observers. Provides interface for attaching and detaching observers. 
    * ConcreteSubject  (IBM) who stores the states of interest and sends notification to observers when the state changes.
    * Observer (IInvestor) defines an updating interface for objects that should be notified of chnages in a subject.
    * ConcreteObserver (Investor) maintains reference to ConcreteSubject. Stores state that is consistent with the subject's state.
    * Implements the observer updating interface to keep state consistent.
     */
    class Program
    {
        //static void Main(string[] args)
        static void Old(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            // Wait for user
            //Console.ReadKey();

            Console.WriteLine();
            RealWorldObserver.TestRealWorldObserver();
        }
    }
}
