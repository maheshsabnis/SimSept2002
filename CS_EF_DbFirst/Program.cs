using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CS_EF_DbFirst
{
    internal class Program
    {
        static DepartmentDataAccess deptDs = new DepartmentDataAccess();
        static  void Main(string[] args)
        {

           // await PrintDepts();
            Console.WriteLine();
          //PrintDept();
            Console.WriteLine();
            //AddDept();
           
            Console.WriteLine();
            // UpdateDept();

            DeleteDept();
            Console.WriteLine();
             PrintDepts();
            Console.ReadLine();
        }

        static void PrintDepts()
        {
            Console.WriteLine("List of Departments");
            foreach (var dept in deptDs.GetDeptAsync().Result)
            {
                Console.WriteLine($"{dept.DeptNo} {dept.DeptName} {dept.Location} {dept.Capacity}");
            }
            Console.WriteLine("List Ends Here");
        }

        static  void PrintDept()
        {
            Console.WriteLine("Searched Department");
            Console.WriteLine("Enter DeptNo to Search");
            int dno = Convert.ToInt32(Console.ReadLine());
         
            var dept =  deptDs.GetDeptByIdAsync(dno).Result;
            Console.WriteLine($"{dept.DeptNo} {dept.DeptName} {dept.Location} {dept.Capacity}");
            Console.WriteLine("Ends Here");
        }

        static void AddDept()
        {
            var dept = new Department()
            {
                 DeptNo =452, DeptName="ITES",Location="Mumbai",Capacity=678
            };
             deptDs.AddDept(dept);
            Console.WriteLine("Department is Added Successfully");
        }


        static void UpdateDept()
        {
            var dept = new Department()
            {
                DeptNo = 452,
                DeptName = "ITES",
                Location = "Mumbai-Andheri",
                Capacity = 678
            };
            deptDs.Update(dept.DeptNo,dept);
            Console.WriteLine("Department is Updated Successfully");
        }

        static void DeleteDept()
        {
             
            deptDs.Delete(452);
            Console.WriteLine("Department is Deleted Successfully");
        }
    }
}
