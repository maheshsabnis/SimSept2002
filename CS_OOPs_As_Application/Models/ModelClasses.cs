using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_As_Application.Models
{
    /// <summary>
    /// The Staff Class that has common Properties
    /// for all Staff Members 
    /// </summary>
    public class Staff
    { 
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int ContactNo { get; set; }
        public string Address{ get; set; }
        public decimal BasicPay { get; set; }
    }
    /// <summary>
    /// Specific Doctor Class
    /// </summary>
    public class Doctor : Staff
    {
        public string DoctorId { get; set; }
        public decimal DoctorFees { get; set; }
        public int MaxNoOfPatientsPerDay { get; set; }
        public int NoOfVisitDaysPerMonth { get; set; }
        public decimal ShareToHospital { get; set; }
        public decimal DoctorMonthlyIncome { get; set; }
    }
    /// <summary>
    /// Specific Nurse Class
    /// </summary>
    public class Nurse:Staff
    {
        public int PatientsHandledInMonth { get; set; }
        public decimal NuserOTAllowance { get; set; }
    }


    public class Accounting
    {
        public decimal GrossIncome { get; set; }
        public decimal TDS { get; set; }
        public decimal NetIncome { get; set; }
    }
}
