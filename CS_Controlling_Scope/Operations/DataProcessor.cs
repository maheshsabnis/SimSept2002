using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CS_Controlling_Scope.Operations
{
    public class DataProcessor
    {
        List<string> names = new List<string>();

        public void AddName(string name)
        {
            names.Add(name);
        }
        /// <summary>
        /// Accessible as Public within the Assembly
        /// </summary>
        internal void SortData()
        {
            names.Sort();
        }

        public void Print()
        {
            foreach (string str in names)
            {
                Console.WriteLine(str);    
            }
        }

        protected void ReverseData()
        {
            names.Reverse();    
        }
        /// <summary>
        /// New Access Specifier in C# 7.0+
        /// </summary>
        private protected void PrintData()
        {
            foreach (string str in names)
            {
                Console.WriteLine(str);
            }
        }
    }

    public class StringListDataProcessor : DataProcessor    
    {
        public void PrintList()
        { 
          base.PrintData(); 
        }
    }
}
