using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OOPs_As_Application.Models;
using CS_OOPs_As_Application.Logics;
namespace CS_OOPs_As_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doct = new Doctor() 
            {
                 StaffId  =101, StaffName="Dr.Anil",ContactNo=99999, Address="SSS", BasicPay=78000,
                 DoctorId ="Doc-11",DoctorFees=400,MaxNoOfPatientsPerDay=20,NoOfVisitDaysPerMonth=40
            };

            DoctorLogic logic = new DoctorLogic();
            logic.GetIncome(doct);

            Console.WriteLine($"Net Invome of Doctor = {doct.DoctorMonthlyIncome}");

            Console.ReadLine();
        }
    }
}
