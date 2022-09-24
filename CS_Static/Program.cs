using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CS_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Add();
            Console.WriteLine($"Add : {Database.numbers}");
            Remove();
            Console.WriteLine($"Remove : {Database.numbers}");
            Console.ReadLine(); 
        }

        static void Add()
        {
            for (int i = 0; i < 10; i++)
            {
                Database.AddNumber(i);  
            }
        }

        static void Remove()
        {
            for (int i = 0; i < 10; i++)
            {
                Database.RemoveNumber(i);
            }
        }
    }



    public static class Database
    { 
        public static List<int> numbers = new List<int>();

        public static void AddNumber(int x)
        { 
            numbers.Add(x); 
        }
        public static void RemoveNumber(int x)
        {
            numbers.Remove(x);
        }
    }
}
