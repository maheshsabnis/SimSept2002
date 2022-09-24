using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lambda
{
    // define a delegate at namespace level
    // this will be used to execute a method that has one integer 
    // input parametere and output interger 
    public delegate int OperationHandler(int value);
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. calling a method using a delegate
            // pass rge reference of the method to delegate 
            OperationHandler handler = new OperationHandler(increment);

            // 2. invoke a method using delegate by passing parameter to it

            Console.WriteLine($"Increment = {handler(10)}");

            Execute(handler);

            Console.WriteLine();
            Console.WriteLine("Passing an implementation to method");

            Execute(delegate(int x) { return x * 100; });

            Console.WriteLine();
            Console.WriteLine("Using Lambda");
            // This will be processed as 'ExpressionTree' in .NET
            // and the Expression will be eveluated as binary with 
            // better performence
            Execute((x) =>{ return x * x * 100; });

            Console.ReadLine();
        }
        /// <summary>
        /// a Method with delegate as its input parameter
        /// </summary>
        /// <param name="h"></param>
        static void Execute(OperationHandler h)
        {
            Console.WriteLine($"After Execution {h(100)}");
        }

        static int increment(int x)
        {
            return x * 10;
        }

    }
}
