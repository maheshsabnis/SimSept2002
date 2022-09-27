using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CS_Thread_Parameters
{
    internal class Program
    {
        static  FileOperations operations = new FileOperations();
        static void Main(string[] args)
        {
            string contents = string.Empty;
            var startTimeToExecuteMainthThread = Stopwatch.StartNew();
          

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Some Other Task ohn Main Thread");
            }
            //var totalTimeOnMainThread = startTimeToExecuteMainthThread.Elapsed.TotalMilliseconds;
            //Console.WriteLine($"Time to Complete Main Thread Operations {totalTimeOnMainThread}");

            //var contents = operations.ReadFile(@"C:\simhealth\MyFile.txt");
            //Console.WriteLine($"File Contents = {contents}");

           
            Thread t = new Thread(() => contents = operations.ReadFile(@"C:\simhealth\MyFile.txt"));
            Thread t1 = new Thread(() => contents = operations.ReadFile(@"C:\simhealth\MyFile.txt"));
            t.Start();
            t1.Start();

            Console.WriteLine();
            Console.WriteLine($"So Total Time to Complete Main Thread = {startTimeToExecuteMainthThread.Elapsed.TotalMilliseconds}");


            for (int i = 0; i < 3; i++)
            {
                Thread mt = new Thread(WriteToFile);
                mt.Name = $"I am Thread No --- {i}";
                mt.Start();
            }





            Console.ReadLine();
        }

        static void WriteToFile()
        {
            Thread.Sleep(100);
            operations.WriteFile();   
        }
    }


    public class FileOperations
    {// Flag
        static object l = new object();
        public string ReadFile(object fileName)
        {
            var fileWriteStart = Stopwatch.StartNew();

            string Contents = string.Empty;

            if (File.Exists(fileName.ToString()))
            {
                using (StreamReader Reader = new StreamReader(fileName.ToString()))
                {
                    Contents = Reader.ReadToEnd();  
                }
                var totalTimeToReadFile = fileWriteStart.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Total Time To Read File Method is = {totalTimeToReadFile}");
                return Contents;
            }
            else
            {
                Contents = "File Not Found.";
                var totalTimeToReadFile = fileWriteStart.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Total Time To Read File Method is = {totalTimeToReadFile}");
                return Contents;
            }
        }

        public void WriteFile()
        {
            Thread.Sleep(1000);
            try
            {
                // The Following code in try block will be blocked for one thread at-a-time  
                // The Synchronization
                Monitor.Enter(l);
                var curThreadName = Thread.CurrentThread.Name;
                using (StreamWriter sw = new StreamWriter(@"C:\simhealth\MyNewFile.txt", true))
                {
                    sw.WriteLine($"Data is Written by Thread {curThreadName}");
                }
                Console.WriteLine($"The Current Thread that was accessing the resource is {curThreadName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred {ex.Message}");
            }
            finally
            {
                Monitor.Exit(l);
            }
        }
    }

}
