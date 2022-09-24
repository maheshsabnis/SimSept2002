using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OOPs_As_Application.Models;
namespace CS_OOPs_As_Application.Logics
{
    /// <summary>
    /// The class which cannot be inherited
    /// </summary>
    public sealed class Accounts
    {

        /// <summary>
        /// The Gateway Method that will decide which StaffLogic and Staff Instance is created
        /// dynamically, this is Dynamic Polymorphism
        /// </summary>
        /// <param name="logic"></param>
        /// <param name="staff"></param>
        /// <returns></returns>
        public Accounting GetTds(StaffLogic logic, Staff staff)
        {
            decimal grossIncome = logic.GetIncome(staff);
            decimal tds = grossIncome * Convert.ToDecimal(0.1);
            decimal netIncome = grossIncome - tds;

            var accounting = new Accounting()
            { 
              GrossIncome = grossIncome,
              TDS = tds,
              NetIncome = netIncome
            };
            return accounting;
        }
    }

  
}
