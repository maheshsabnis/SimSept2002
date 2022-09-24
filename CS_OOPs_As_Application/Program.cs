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
            Doctor doctor = new Doctor() 
            {
                 StaffId  =101, StaffName="Dr.Anil",ContactNo=99999, Address="SSS", BasicPay=78000,
                 DoctorId ="Doc-11",DoctorFees=400,MaxNoOfPatientsPerDay=20,NoOfVisitDaysPerMonth=40
            };

            DoctorLogic doctorLogic = new DoctorLogic();

            doctorLogic.AddDoctor(doctor);

            var docs = doctorLogic.GetDoctors();


          //  doctorLogic.GetIncome(doctor);

           // Console.WriteLine($"Net Invome of Doctor = {doct.DoctorMonthlyIncome}");

            Accounts accounts = new Accounts();

            Accounting accounting = accounts.GetTds(doctorLogic, doctor);

            Console.WriteLine($"Accounting for Doctor" +
                $"Gross Income is Rs. {accounting.GrossIncome}/- TDS is Rs. {accounting.TDS}/- Net Income is Rs. {accounting.NetIncome}/-");


            Nurse nurse = new Nurse()
            {
                StaffId = 1002, StaffName="Sist. Naarmada", ContactNo=9999, Address="DDD",BasicPay=8000,
                NuserOTAllowance = 5000,PatientsHandledInMonth=100
            };

            NurseLogic nurseLogic = new NurseLogic();

            nurseLogic.AddNurse(nurse);

            var nurss = nurseLogic.GetNurses();

            // var netincome = nurseLogic.GetIncome(nurse);
            //   Console.WriteLine($"Net Income of Nurse = {netincome}");


            accounting = accounts.GetTds(nurseLogic, nurse);

            Console.WriteLine($"Accounting for Nurse" +
               $"Gross Income is Rs. {accounting.GrossIncome}/- TDS is Rs. {accounting.TDS}/- Net Income is Rs. {accounting.NetIncome}/-");

            Console.ReadLine();
        }
    }
}
