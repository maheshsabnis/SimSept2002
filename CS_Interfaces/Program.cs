using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CS_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using Class Instance to access method from interface
            FileOperations fileOp = new FileOperations();
            fileOp.FileCreate("File1.txt");
            fileOp.FileCreate("File1.txt");
            // Using an Interface Reference
            IFileOperations iFileOp = new FileOperations();
            iFileOp.FileCreate("File2.txt");
            iFileOp.FileWrite("File2.txt");

            // Use an interface Reference to access methods from class
            IFileOperations dataFileOp = new DataFileOperations();

            dataFileOp.FileCreate("File3.txt");
            dataFileOp.FileWrite ("File3.txt");

            IXmlFileOperations xmlFileOp = new DataFileOperations();
            xmlFileOp.FileCreate("File4.xml");
            xmlFileOp.FileWrite("File4.xml");

            Console.WriteLine();
            Console.WriteLine("using Gateway");
            Gateway gateway = new Gateway();
            // Polymorphic behavior using interface references
            gateway.FileOp(dataFileOp, "file5.txt");
            Console.WriteLine();
            gateway.FileOp(xmlFileOp, "file6.xml");

            List<int> lstInt = new List<int>();
            lstInt.Add(1);
            lstInt.Add(2);

            var intArray = lstInt.ToArray();

            Console.ReadLine(); 
        }
    }
}
