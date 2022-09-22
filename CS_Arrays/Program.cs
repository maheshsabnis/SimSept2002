using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArr = new int[5];

            intArr[0] = 100;
            intArr[1] = 200;
            intArr[2] = 300;
            intArr[3] = 400;
            intArr[4] = 500;

            ArrayList arr = new ArrayList();

            for (int i = 0; i < 5000; i++)
            {
                arr.Add(i);
            }

            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine(arr[i]);
            }
           

            

            Console.ReadLine(); 
        }
    }
}
