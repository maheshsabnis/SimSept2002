using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Fluent_API.Models;
namespace CS_Fluent_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RFSalesDbContext context = new RFSalesDbContext();

                if (context.Database.Exists())
                {
                    context.Database.Delete();  
                }


                var customers = context.Customers;

                var orders = context.Orders;

                var customer = new Customer()
                {
                    CustomerName = "Leena",
                    Address = "Bavdhan",
                    City = "Pune",
                    District = "Pune",
                    State="Maharashtra",
                    MobileNo="444444",
                    PhoneNo="33333355555454"
                };

                context.Customers.Add(customer);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred {ex.Message}");
            }
            Console.ReadLine(); 
        }
    }
}
