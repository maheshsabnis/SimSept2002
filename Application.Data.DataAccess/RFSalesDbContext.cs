using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Application.Model.Entities;
 

namespace Application.Data.DataAccess
{
    public class RFSalesDbContext : DbContext
    {
        public RFSalesDbContext():base("name=RFSalesDbContextConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
