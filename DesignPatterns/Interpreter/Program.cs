using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    /**
     * AbstractExpression  (Expression) declares an interface for executing an operation
     * TerminalExpression  ( ThousandExpression, HundredExpression, TenExpression, OneExpression ) implements an Interpret operation associated with terminal symbols in the grammar.
     * NonterminalExpression  ( not used )
     * Context  (Context) contains information that is global to the interpreter
     * Client  (InterpreterApp)
     * 
     */
    class Program
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);
            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());
            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}", roman, context.Output);
            // Wait for user
            Console.ReadKey();
        }
    }
}
