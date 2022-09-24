using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Controlling_Scope.Operations;
namespace CS_Consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Names = new string[]
         {
                "Mahesh", "Mukesh", "Manoj", "Manish", "Madhukar", "Madhusudan", "Mukund", "Ramesh", "Rajesh", "Rohit", "Ram", "Ravi", "Ravindranath", "Tejas", "Trilok", "Trivikram", "Tarun", "Vikram", "Vikas", "Vinod", "Vasideo", "Vasudev", "Chaitanya", "Chirag", "Chinmay", "Chimanrao", "Gundyabhau","Ganesh", "Ganesh"
         };

          
           
            Console.ReadLine(); 
        }
    }

    public class ListDataProcessor : DataProcessor
    {
        /// <summary>
        /// Accessing the Protected Member of the Base class from different Assembly 
        /// </summary>
        /// <param name="str"></param>
        public void ReverseDataOfBase(List<string> str)
        {
            // Protected Member
            base.ReverseData();

        }
    }
}
