using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OOPs_Fundamentals.Models;

namespace CS_OOPs_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Staff of the Type Doctor
            Staff staff = new Staff()
            { 
              StaffId=1, StaffName="A",StaffType="Doctor",BasicPay=20000,DoctorFees=4000
            };

            StaffLogic staffLogic = new StaffLogic();

            var staffs = staffLogic.RegisterStaff(staff);

            Staff staff1 = new Staff()
            {
                StaffId = 2,
                StaffName = "B",
                StaffType = "Nurse",
                BasicPay = 4000,
                NuresePatientAllowance =450
            };

            staffs = staffLogic.RegisterStaff(staff1);

            Staff staff2 = new Staff()
            {
                StaffId = 3,
                StaffName = "C",
                StaffType = "Wardboy",
                BasicPay = 2200,
                WardboyOverTimeHours = 20,
                WardborHourlyAllowance = 100
            };

            staffs = staffLogic.RegisterStaff(staff2);

            staffs = staffLogic.GetStaffs();


            foreach (Staff stf in staffs)
            {
                Console.WriteLine($"{stf.StaffId} {stf.StaffName} {stf.StaffType} {staff.BasicPay} {stf.DoctorFees} {stf.NuresePatientAllowance} {stf.WardborHourlyAllowance} {stf.WardboyOverTimeHours}");
            }


            Console.ReadLine();
        }
    }
}
