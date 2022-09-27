using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Parallel_Invoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res1 = string.Empty;
            string res2 = string.Empty;
            FileOperations operations = new FileOperations ();
            // Interact with CLR and demand for threads
            Parallel.Invoke(() => {
                res1 = operations.ReadFileOne();
                res2 = operations.ReadFileTwo();
            });

            Console.WriteLine($"Data From File 1 = {res1}");
            Console.WriteLine($"Data from File 2 = {res2}");

            Console.ReadKey();  
        }
    }


    public class FileOperations
    {
        public string ReadFileOne()
        {
            string contents = string.Empty;

            using (StreamReader sr = new StreamReader(@"C:\simhealth\MyFile.txt"))
            {
                contents = sr.ReadToEnd();  
            }
            return contents;
        }

        public string ReadFileTwo()
        {
            string contents = string.Empty;

            using (StreamReader sr = new StreamReader(@"C:\simhealth\MyNewFile.txt"))
            {
                contents = sr.ReadToEnd();
            }
            return contents;
        }
    }
}
