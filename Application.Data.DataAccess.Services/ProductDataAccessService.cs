using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Model.Entities;
using Application.Data.Contract;
using Application.Data.DataAccess;

namespace Application.Data.DataAccess.Services
{
    public class ProductDataAccessService : IDbAccess<Product, int>
    {
        RFSalesDbContext ctx;
        public ProductDataAccessService()
        {
            ctx = new RFSalesDbContext();
        }

        public Product Create(Product enity)
        {
            try
            {
                var result = ctx.Products.Add(enity);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return enity;
        }

        public Product Delete(int id)
        {
            Product recToDelete = null;
            try
            {
                recToDelete = ctx.Products.Find(id);
                if (recToDelete == null)
                    throw new Exception("Recotd to Delete is not found");
                ctx.Products.Remove(recToDelete);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return recToDelete;
        }

        public IEnumerable<Product> Get()
        {
            try
            {
                return ctx.Products.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product Get(int id)
        {
            Product record = null;
            try
            {
                record = ctx.Products.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return record;
        }

        public Product Update(int id, Product enity)
        {
            Product record = null;
            try
            {
                record = ctx.Products.Find(id);
                if (record == null)
                    throw new Exception("Recotd to be updated is not found");
                if (id != enity.CategoryUniqueId)
                    throw new Exception("The Product Unique Id Value in URL Does not match with the Product Unique Id Value in Model data");

                record.ProductId = enity.ProductId;
                record.ProductName = enity.ProductName;
                record.Manufacturer = enity.Manufacturer;
                record.Description = enity.Description;
                record.Price = enity.Price;
                record.Vat = enity.Vat;
                record.TotalPrice = enity.TotalPrice;
                record.CategoryUniqueId = enity.CategoryUniqueId;
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return record;
        }
    }
}
