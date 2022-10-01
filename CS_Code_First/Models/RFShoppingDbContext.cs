using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CS_Code_First.Models
{
    internal class RFShoppingDbContext : DbContext
    {
        // This will read the App.Config file with <connectionStrings> section
        // with Connection string anme as  RFShoppingDbContextConnection
        public RFShoppingDbContext():base("name=RFShoppingDbContextConnection")
        {
        }
        // define DbSet properties those will be used to create table
        // Plularize the PRoeprtyName
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        // override OnModelCreating() method
        // This will be invoked by the base class to 
        // Read DbSet mapped CLR classes and will generate Tables from it
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
