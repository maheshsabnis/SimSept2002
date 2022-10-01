using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CS_Fluent_API.Models
{
    internal class RFSalesDbContext: DbContext
    {
        public RFSalesDbContext():base("name=RFSalesDbContextConnection")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Lets use the Fluent APIs

            // 1. Define a Key for Customer
            modelBuilder.Entity<Customer>().HasKey(c=>c.CustomerId);
            // 2. Let the CustomerId be an Identity Key
            modelBuilder.Entity<Customer>().Property(c => c.CustomerId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            // 3. Set MaxLength for String Properties
            modelBuilder.Entity<Customer>().Property(c => c.CustomerName).IsRequired().HasMaxLength(80);
            modelBuilder.Entity<Customer>().Property(c => c.Address).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Customer>().Property(c => c.City).IsRequired().HasMaxLength(80);
            modelBuilder.Entity<Customer>().Property(c => c.State).IsRequired().HasMaxLength(80);
            modelBuilder.Entity<Customer>().Property(c => c.MobileNo).IsRequired().HasMaxLength(12);
            modelBuilder.Entity<Customer>().Property(c => c.PhoneNo).IsRequired().HasMaxLength(40);
            modelBuilder.Entity<Customer>().Property(c => c.District).IsRequired().HasMaxLength(80);


            // 4. Now for Order

            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            // 5. Let the OrderId be an Identity Key
            modelBuilder.Entity<Order>().Property(o => o.OrderId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Order>().Property(o => o.OrderedItem).HasMaxLength(60);
            // 6. Lets set the CustomerId property from Order class as Foreign Key
            // The Order is from One Customer but the Customer may have many Orders and they
            // are linked by the CustomerId in Order Table
            modelBuilder.Entity<Order>().HasRequired(c=>c.Customer).WithMany(o=>o.Orders).HasForeignKey(o=>o.CustomerId);

            // Cascade Delete from Custome to Orders

            modelBuilder.Entity<Order>()
                .HasRequired(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.CustomerId)
                .WillCascadeOnDelete(true);


            base.OnModelCreating(modelBuilder);
        }
    }
}
