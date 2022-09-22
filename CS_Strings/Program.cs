using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CS_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string str = "James Andrew Bond";

            //  string str = string.Empty; // Recommended Initialization
           // string str = null;
            Console.WriteLine("Original");
            Console.WriteLine(str);
            PrintUpperCase (str);
            Console.WriteLine($"Print {str}");

            string[] actors = new string[] {
               "Sean Connary", "George Luznaby", "Roger Moore","Trimothy Dalton", "Pierce Bronson", null, "Daniel Craig", null, null, "Who Next to play James Bond?"
            };

            var essayResult = Concatination(actors);

            Console.WriteLine($"Essay Result = {essayResult}");

            Console.WriteLine();

           var result =  String.Concat(actors);

            Console.WriteLine($"Usoing Concat {result}");



            Console.ReadLine(); 
        }


        static void PrintUpperCase(string ipstr)
        {
            // if (ipstr != null || ipstr.Length >= 0)
            if(!string.IsNullOrEmpty(ipstr))
            {
                Console.WriteLine($"Upper Case = {ipstr.ToUpper()}");
            }
        }

        static string Concatination(string[] strings)
        {
            string essay = string.Empty;
            // Always check if array contains items or entries in it
            if (strings.Length > 0)
            {
                foreach (var str in strings)
                {
                    if (!String.IsNullOrEmpty(str))
                    {
                        essay += str;
                    }
                    else
                    {
                        continue; // conmtinue with next record in Array
                    }
                }
            }

            return essay;
        }


    }
}
