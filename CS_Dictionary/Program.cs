using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO Dictionary");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Mahesh");
            dictionary.Add(2, "Tejas");
            dictionary.Add(3, "Neeta");
            dictionary.Add(4, "Ramesh");

            // prinat all Keys

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"Vale at {key} key is =  {dictionary.TryGetValue(key, out string value)}");
                Console.WriteLine(value );
            }

            Dictionary<int, Employee> empDict = new Dictionary<int, Employee>();
            empDict.Add(1, new Employee() { EMpNo=101,EmpName="A"});
            empDict.Add(1, new Employee() { EMpNo = 102, EmpName = "B" });
            empDict.Add(1, new Employee() { EMpNo = 103, EmpName = "C" });
            empDict.Add(1, new Employee() { EMpNo = 104, EmpName = "D" });



            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EMpNo { get; set; }
        public string EmpName { get; set; }
    }
}
