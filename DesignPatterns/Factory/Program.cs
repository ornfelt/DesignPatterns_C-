using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    /**
     * The Factory Method design pattern defines an interface for creating an object, 
     * but let subclasses decide which class to instantiate.
     * This pattern lets a class defer instantiation to subclasses.
     * 
     * Product  (Page) defines the interface of objects the factory method creates.
     * ConcreteProduct (SkillsPage, EducationPage, ExperiencePage) implements the Product interface.
     * Creator  (Document) declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
     * ConcreteCreator  (Report, Resume) overrides the factory method to return an instance of a ConcreteProduct.
     *
     */
    class Program
    {
        //public static void Main (String[] args)
        public static void Old (String[] args)
        {
            // An array of creators
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
