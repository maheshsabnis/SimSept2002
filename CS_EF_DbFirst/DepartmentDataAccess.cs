using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EF_DbFirst
{
    internal class DepartmentDataAccess
    {
        RFCompanyEntities ctx;

        public DepartmentDataAccess()
        {
            ctx = new RFCompanyEntities();
        }

        public async Task<IEnumerable<Department>> GetDeptAsync()
        {
            var depts = await ctx.Departments.ToListAsync();
            return depts;
        }

        public async Task<Department> GetDeptByIdAsync(int id)
        {
            var dept = await ctx.Departments.FindAsync(id);
            return dept;
        }

        public Department AddDept(Department department)
        {
            var dept =  ctx.Departments.Add(department);
            ctx.SaveChanges();
            return dept;
        }

        public Department Update(int id, Department department)
        {
            var deptToUpdate = ctx.Departments.Find(id);
            if (deptToUpdate != null)
            {
                deptToUpdate.DeptName = department.DeptName;
                deptToUpdate.Location = department.Location;
                deptToUpdate.Capacity = department.Capacity;
                ctx.SaveChanges();
                return deptToUpdate;
            }
            else
            {
                return new Department(); 
            }
        }

        public bool Delete(int id)
        {
            var deptToDelete = ctx.Departments.Find(id);
            if (deptToDelete != null)
            {
                ctx.Departments.Remove(deptToDelete);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
