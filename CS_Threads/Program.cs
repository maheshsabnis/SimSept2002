using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            
            Thread t1 = new Thread(m.Increment);
            Thread t2 = new Thread(m.Decrement);
            // Highest
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Main Thread {i}");
            }



            Console.ReadLine() ;
        }
    }

    class MyClass
    {
        public void Increment()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Increment {i}");
                // Block the Execution of tne Thread that is executing this method
                Thread.Sleep(500);
            }
        }


        public void Decrement()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Decrement {i}");
            }
        }

    }
}
