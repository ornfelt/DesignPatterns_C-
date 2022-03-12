using System;

namespace DesignPatterns.Testing
{
    class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            //TestLinkedList.TestRunLinkedList();

            //SinglyLinkedList linkedList = new SinglyLinkedList();
            //linkedList.Append("test");
            //linkedList.Append("test2");
            //Console.WriteLine("Last in list: " + linkedList.Last.data);
            //linkedList.Append("test3");
            //linkedList.Append("test4");
            //Console.WriteLine("Last in list: " + linkedList.Last.data);
            //Console.WriteLine("First in list: " + linkedList.First.data);
            //linkedList.Delete(linkedList.First);
            //Console.WriteLine("First in list: "+ linkedList.First.data);

            // Test composition
            //CompositionMonster.TestCompositionMonster();
            TestEmps();
            Console.ReadLine();
        }

        private static void TestEmps()
        {
            Employee[] employees = new Employee[10];
            employees[0] = new Secretary("bert jones");
            employees[1] = new Employee("test");
            Console.WriteLine(employees[0].GetSalary());
            Console.WriteLine(employees[1].GetSalary());
        }
    }
}
