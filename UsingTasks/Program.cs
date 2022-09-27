using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTasks
{
    internal class Program
    {
        /// <summary>
        /// Main Method async an Offering of .NET 4.5
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
            FileOperations operations = new FileOperations();

            string res1 = string.Empty, res2 = string.Empty;
            //// An Async Call
            //Task<string> task = Task.Factory.StartNew<string>(() => {
            //    {
            //        res1 = operations.ReadFileOne();
            //        res2 = operations.ReadFileTwo();
            //    }
            //    return $"{res1}" +
            //    $"{res2}";
            //});

            //// Get the Data back from the Task
            //// Main Thread
            //Console.WriteLine($"Data From File {task.Result}");


            Task<string> t1 = Task.Factory.StartNew<string>(() => {
                return operations.ReadFileOne();
            });

            Task<string> t2 = Task.Factory.StartNew<string>(() => {
                return operations.ReadFileTwo();
            });

            // Back to Main Thread to Collect the Data
            
            res1 = t1.Result;
            res2 = t2.Result;

            Console.WriteLine(res1);
            Console.WriteLine(res2);


            Console.WriteLine();
            Console.WriteLine("Calling Async Method");

            AsyncFileOperations fileOperations = new AsyncFileOperations();

            var r1 = await fileOperations.ReadFileOneAsync();

            var r2 = await fileOperations.ReadFileOneAsync();

            Console.WriteLine(r1);
            Console.WriteLine(r2);




            Console.ReadLine();
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


    public class AsyncFileOperations
    {
        public async Task<string> ReadFileOneAsync()
        {
            string contents = string.Empty;

            using (StreamReader sr = new StreamReader(@"C:\simhealth\MyFile.txt"))
            {
                contents = await sr.ReadToEndAsync();
            }
            return contents;
        }

        public async Task<string> ReadFileTwoAsync()
        {
            string contents = string.Empty;

            using (StreamReader sr = new StreamReader(@"C:\simhealth\MyNewFile.txt"))
            {
                contents = await sr.ReadToEndAsync();
            }
            return contents;
        }
    }
}
