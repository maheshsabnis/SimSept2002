using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LINQ
{
    internal class Program
    {
        static EmployeeList employees = new EmployeeList(); 
        static void Main(string[] args)
        {
            PrintEmpsByDesignation("Manager");
            Console.WriteLine();
            PrintEmpsByDesignationOrderByEmpName("Manager");
            Console.WriteLine();
            PrintSumSalaryGroupByDesignation();
            Console.WriteLine();
            GetSpecifCountFromTop(7);
            Console.WriteLine();
            GetSpecifRecordsWithFilters(4,3);
            Console.WriteLine(  );
            UpdateTaxForManagers();
            Console.ReadLine();
        }

        static void PrintEmpsByDesignation(string designation)
        {
            var result = (from e in employees
                         where e.Designation == designation
                         select e).ToList();

            Print(result);
        }

        static void PrintEmpsByDesignationOrderByEmpName(string designation)
        {
            var result = (from e in employees
                          where e.Designation == designation
                          orderby e.EmpName
                          select e).ToList();

            Print(result);
        }


        static void PrintSumSalaryGroupByDesignation()
        {
            // group key as designation
            var result = (from e in employees
                          group e by e.Designation into grp
                          select new { 
                            Designation = grp.Key,
                            Salary = grp.Sum(e=>e.Salary)
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Designation} {item.Salary}");
            }
            
        }

        static void GetSpecifCountFromTop(int records)
        { 
            var result = employees.Take(records).ToList();
            Print(result);
        }


        static void GetSpecifRecordsWithFilters(int skip, int take)
        {
            var result = employees.Skip(skip).Take(take).ToList();
            Print(result);
        }

        static void UpdateTaxForManagers()
        {
            var result = (from e in employees
                          where e.Designation == "Manager"
                          select e).ToList();
            // Update the Resultant by Ref
            result.ForEach(e => e.TDS = Convert.ToDecimal( e.Salary *  0.15));

            Print(result);

        }

        static void Print(IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.Designation} {emp.TDS}");
            }
        }
    }


    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = String.Empty;
        public int Salary { get; set; }
        public decimal TDS { get; set; }
        public string Designation { get; set; }
    }

    public static class ProcessTax
    {
        public static Employee CalculateTax(Employee emp)
        {
            System.Threading.Thread.Sleep(100);
            emp.TDS = emp.Salary * Convert.ToDecimal(0.1);
            return emp;
        }
    }

    public class EmployeeList : List<Employee>
    {
        public EmployeeList()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "Abhay", Salary = 11000, Designation="Manager" });
            Add(new Employee() { EmpNo = 102, EmpName = "Baban", Salary = 22000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 103, EmpName = "Chaitanya", Salary = 33000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 104, EmpName = "Deepak", Salary = 44000, Designation = "Director" });
            Add(new Employee() { EmpNo = 105, EmpName = "Eshwar", Salary = 55000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 106, EmpName = "Falgun", Salary = 66000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 107, EmpName = "Ganpat", Salary = 77000, Designation = "Director" });
            Add(new Employee() { EmpNo = 108, EmpName = "Hitesh", Salary = 88000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 109, EmpName = "Ishan", Salary = 99000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 110, EmpName = "Jay", Salary = 31000, Designation = "Director" });
            Add(new Employee() { EmpNo = 111, EmpName = "Kaushubh", Salary = 21000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 112, EmpName = "Lakshman", Salary = 22000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 113, EmpName = "Mohan", Salary = 23000, Designation = "Director" });
            Add(new Employee() { EmpNo = 114, EmpName = "Naveen", Salary = 24000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 115, EmpName = "Omkar", Salary = 25000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 116, EmpName = "Prakash", Salary = 26000, Designation = "Director" });
            Add(new Employee() { EmpNo = 117, EmpName = "Qumars", Salary = 27000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 118, EmpName = "Ramesh", Salary = 28000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 119, EmpName = "Sachin", Salary = 29000, Designation = "Director" });
            Add(new Employee() { EmpNo = 120, EmpName = "Tushar", Salary = 30000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 121, EmpName = "Umesh", Salary = 31000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 122, EmpName = "Vivek", Salary = 32000, Designation = "Director" });
            Add(new Employee() { EmpNo = 123, EmpName = "Waman", Salary = 33000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 124, EmpName = "Xavier", Salary = 34000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 125, EmpName = "Yadav", Salary = 35000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 126, EmpName = "Zishan", Salary = 36000, Designation = "Director" });

        }
    }
}
