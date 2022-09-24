using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interfaces
{
    public interface IFileOperations
    {
        void FileCreate(string fileName);
        void FileWrite(string fileName);
    }


    public interface IXmlFileOperations
    {
        void FileCreate(string fileName);
        void FileWrite(string fileName);
    }

    /// <summary>
    /// Class is implementing interface implicitly
    /// </summary>
    public class FileOperations : IFileOperations
    {
        public void FileCreate(string fileName)
        {
            Console.WriteLine($"File Created {fileName}");
        }

        public void FileWrite(string fileName)
        {
            Console.WriteLine($"File Written {fileName}");
        }
    }

    public class DataFileOperations : IFileOperations, IXmlFileOperations
    {
        void IFileOperations.FileCreate(string fileName)
        {
            Console.WriteLine($"File is Creted {fileName}");
        }

        void IXmlFileOperations.FileCreate(string fileName)
        {
            Console.WriteLine($"XML File is Creted {fileName}");
        }

        void IFileOperations.FileWrite(string fileName)
        {
            Console.WriteLine($"File is Written {fileName}");
        }

        void IXmlFileOperations.FileWrite(string fileName)
        {
            Console.WriteLine($"XML File is Written {fileName}");
        }
    }


    /// <summary>
    /// Gateway class with Ovberloaded methods
    /// </summary>
    public class Gateway
    {
        public void FileOp(IFileOperations file, string fileName)
        {
            file.FileCreate(fileName);
            file.FileWrite(fileName);
        }


        public void FileOp(IXmlFileOperations file, string fileName)
        {
            file.FileCreate(fileName);
            file.FileWrite(fileName);
        }

    }


    public interface IOperations
    {
        int Add(int x, int y);
        // ONly SUpported in C# 8.0
        //int Sub(int x, int y)
        //{
        //    return x - y;
        //}
    }
}

