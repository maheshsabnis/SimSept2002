using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Parallel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeList employees = new EmployeeList();

            Console.WriteLine("Sequential Execution using for..loop");

            var timeElapsed = Stopwatch.StartNew();

            for (int i = 0; i < employees.Count; i++)
            {
                employees[i] = ProcessTax.CalculateTax(employees[i]);

                Console.WriteLine($"With Sequential Excution TDS of Emplyee {employees[i].EmpNo} = {employees[i].TDS}");
            }

            var totalNonParallelTime = timeElapsed.Elapsed.Milliseconds;
            Console.WriteLine($"Total time for Seqnential execution is = {totalNonParallelTime}");
            Console.WriteLine("Ends Here");

            Console.WriteLine();
            Console.WriteLine("Using .NET 4.0 Parallel Processing");
            var timeElapsedParalle = Stopwatch.StartNew();

            Parallel.For(0,employees.Count, (i) => {

                employees[i] = ProcessTax.CalculateTax(employees[i]);
                Console.WriteLine($"With Parallel Excution TDS of Emplyee {employees[i].EmpNo} = {employees[i].TDS}");

                // Write the Processed record in file

            });

            var totalTimeForParalle = timeElapsedParalle.Elapsed.Milliseconds;
            Console.WriteLine($"Total time for Parallel Processing = {totalTimeForParalle}");
            Console.WriteLine("Ends Here");

            Console.ReadLine(); 
        }
    }
}
