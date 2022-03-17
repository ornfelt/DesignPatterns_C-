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

            // Test employee salaries (from pp in csd)
            //TestEmps();
            //Console.ReadLine();

            // Test pointers (needs compiling with /unsafe)
            //PointerMethod();

            // Test contract class
            ContractTesting.StartContractTesting();
        }

       // public unsafe void PointerMethod()  
       // {  
       //     int x = 10;  
       //     int y = 20;  
       //     int* sum = Swap(&x, &y);  
       //     Console.WriteLine(*sum);  
       // }  

       // public unsafe int* Swap(int* x, int* y)  
       // {  
       //     int sum;  
       //     sum = *x + *y;  
       //     return ∑  
       // }

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
