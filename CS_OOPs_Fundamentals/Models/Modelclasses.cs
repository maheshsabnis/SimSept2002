using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_Fundamentals.Models
{
    /// <summary>
    /// The class that will be used to store Staff information for the statff 
    /// working with Hospital, 
    /// all members of the class are 'private' by default
    /// </summary>
    public class Staff
    {
        int _StaffId;
        public int StaffId { get { return _StaffId; } set { _StaffId = value; } }
        string _StaffName;
        public string StaffName { get { return _StaffName; } set { _StaffName = value; } }
        string _StaffType;
        public string StaffType { get { return _StaffType; } set { _StaffType = value; } }
        decimal _BasicPay;
        public decimal BasicPay { get { return _BasicPay; } set { _BasicPay = value; } }
        decimal _DoctorFees;
        public decimal DoctorFees { get { return _DoctorFees; } set { _DoctorFees = value; } }
        decimal _NuresePatientAllowance;
        public decimal NuresePatientAllowance { get { return _NuresePatientAllowance; } set { _NuresePatientAllowance = value; } }
        decimal _WardboyOverTimeHours;
        public decimal WardboyOverTimeHours { get { return _WardboyOverTimeHours; } set { _WardboyOverTimeHours = value; } }
        decimal _WardborHourlyAllowance;
        public decimal WardborHourlyAllowance { get { return _WardborHourlyAllowance; } set { _WardborHourlyAllowance = value; } }

        public short NoOfPatientsPerDay { get; set; }
    }

    /// <summary>
    /// Logic class that contains Behavior to Process the Staff Data
    /// </summary>
    public class StaffLogic
    {
        List<Staff> staffs = new List<Staff>();

        public List<Staff> GetStaffs()
        {
            return staffs;
        }
        public List<Staff> RegisterStaff(Staff staff)
        {
            staffs.Add(staff);  
            return staffs;
        }

    }
}
