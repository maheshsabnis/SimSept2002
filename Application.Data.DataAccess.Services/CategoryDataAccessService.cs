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
    public class CategoryDataAccessService: IDbAccess<Category, int>
    {
        RFSalesDbContext ctx;
        public CategoryDataAccessService()
        {
            ctx = new RFSalesDbContext();
        }

        public Category Create(Category enity)
        {
            try
            {
              var result = ctx.Categories.Add(enity);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return enity;
        }

        public Category Delete(int id)
        {
            Category recToDelete = null;
            try
            {
                recToDelete = ctx.Categories.Find(id);
                if (recToDelete == null)
                    throw new Exception("Recotd to Delete is not found");
                ctx.Categories.Remove(recToDelete);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return recToDelete;
        }

        public IEnumerable<Category> Get()
        {
            try
            {
                return ctx.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category Get(int id)
        {
            Category record = null;
            try
            {
                record = ctx.Categories.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return record;
        }

        public Category Update(int id, Category enity)
        {
            Category record = null;
            try
            {
                  record = ctx.Categories.Find(id);
                if (record == null)
                    throw new Exception("Recotd to be updated is not found");
                if (id != enity.CategoryUniqueId)
                    throw new Exception("The Category Unique Id Value in URL Does not match with the Category Unique Id Value in Model data");
                record.CategoryId = enity.CategoryId;
                record.CategoryName = enity.CategoryName;
                record.BasePrice = enity.BasePrice;
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
