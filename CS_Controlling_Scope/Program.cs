using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Controlling_Scope.Operations;
namespace CS_Controlling_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataProcessor processor = new DataProcessor();

            string[] Names = new string[]
            {
                "Mahesh", "Mukesh", "Manoj", "Manish", "Madhukar", "Madhusudan", "Mukund", "Ramesh", "Rajesh", "Rohit", "Ram", "Ravi", "Ravindranath", "Tejas", "Trilok", "Trivikram", "Tarun", "Vikram", "Vikas", "Vinod", "Vasideo", "Vasudev", "Chaitanya", "Chirag", "Chinmay", "Chimanrao", "Gundyabhau","Ganesh", "Ganesh"
            };

            foreach (var item in Names)
            {
                processor.AddName(item);
            }
            // Internal Method accessible within the assembly
            processor.SortData();

            processor.Print(); 


            Console.ReadLine(); 
        }
    }

    public class ListStringDataProcessor : DataProcessor
    {
        public void PrintDataFromList()
        {
            // Provate Protected method accessible
            // only within the derived class of the assembly
            base.PrintData();
        }
    }
}
