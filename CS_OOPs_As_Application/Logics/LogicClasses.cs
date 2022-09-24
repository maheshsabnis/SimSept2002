using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OOPs_As_Application.Models;
using CS_OOPs_As_Application.Database;
namespace CS_OOPs_As_Application.Logics
{
    /// <summary>
    /// The Abstract class
    /// </summary>
    public abstract class StaffLogic
    {
        //public abstract List<Staff> GetAllStaff();
        //public abstract List<Staff> RegisterStaff(Staff staff);
        /// <summary>
        /// A Method with Default Implementation
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public virtual decimal GetIncome(Staff staff)
        {
            return staff.BasicPay;
        }
    }

    public class DoctorLogic : StaffLogic
    {
        List<Doctor> doctors =  new List<Doctor>();

        //public override List<Staff> GetAllStaff()
        //{
        //    List<Staff> staffs = new List<Staff>();

        //    foreach (Doctor doctor in doctors)
        //    {
        //        staffs.Add(doctor);
        //    }
        //    return staffs;
        //}

        //public override List<Staff> RegisterStaff(Staff staff)
        //{
        //    // Downcasting
        //    Doctor doctor = (Doctor)staff;
        //    doctors.Add(doctor);
        //    List<Staff> staffs = new List<Staff>();

        //    foreach (Doctor doc in doctors)
        //    {
        //        staffs.Add(doctor);
        //    }
        //    return staffs;
        //}

        public List<Doctor> GetDoctors()
        {
            foreach (var doct in ApplicationDb.Staffs)
            {
                doctors.Add((Doctor)doct);
            };
            return doctors;
        }
        public List<Doctor> AddDoctor(Doctor doctor)
        {
            ApplicationDb.Staffs.Add(doctor);
           // doctors.Add(doctor);
            return doctors;
        }

        public override decimal GetIncome(Staff staff)
        {
            // cast the staff to doctor
            Doctor doctor = (Doctor) staff; // Downcasting
            // Get Basic Pay from the BAse
            decimal NetIncome = base.GetIncome(staff) + (doctor.DoctorFees * doctor.MaxNoOfPatientsPerDay * doctor.NoOfVisitDaysPerMonth);

            // calculate Hopsital Share as 20% of NetIncome

            doctor.ShareToHospital = NetIncome * Convert.ToDecimal(0.2);

            // Net Monthly Income

            doctor.DoctorMonthlyIncome = NetIncome - doctor.ShareToHospital;
            return doctor.DoctorMonthlyIncome;

        }
    }


    public class NurseLogic : StaffLogic 
    {
        List<Nurse> Nurses = new List<Nurse>();

        public List<Staff> GetNurses()
        {
            return ApplicationDb.Staffs;
        }

        public List<Nurse> AddNurse(Nurse nurse)
        {
            Nurses.Add(nurse);
            ApplicationDb.Staffs.Add(nurse);    
            return Nurses;
        }

        public override decimal GetIncome(Staff staff)
        {
            Nurse nurse = (Nurse)staff; // Downcasting

            decimal NetIncome = base.GetIncome(staff) + (nurse.PatientsHandledInMonth * 100) + nurse.NuserOTAllowance;

            return NetIncome;

        }
    }
}
