using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SourceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class MyDemoClass
    {
        List<Employee> Employees = new List<Employee>();

        public MyDemoClass()
        {
            Employees.Add(new Employee() { EmpNo = 1001, EmpName = "Mahesh" });
            Employees.Add(new Employee() { EmpNo = 1002, EmpName = "Ramesh" });
            Employees.Add(new Employee() { EmpNo = 1003, EmpName = "Tejas" });
        }
        /// <summary>
        /// Used Case (Story): Write a Method that Accepts 2 Integers, add them and return integer
        /// Test Case (Invalid-Verification): Make sure that both parameters are integers and the return value is also integer
        /// Test Case (verifi0cation): MAke sure that input parameters are non -ve integers  
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Add(int x, int y)
        {
            if (x < 0|| y < 0 ) throw new Exception("x and y must be + integer");
            return x + y;
        }

        public string Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "User Nsme and Password Can not be zero";
            }
            if (username == "mahesh" && password == "mahesh")
            {
                return "Login Successful";
            }
            return "Login Failed";
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public Employee GetDetails(int id)
        {
            Employee employee = null;

            if (id == 0) return null;

            if (id < 0) throw new Exception("EmpNo can not bew -VE");

            employee = Employees.FirstOrDefault(e => e.EmpNo == id);

            return employee;
        }
    }


    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }
}
