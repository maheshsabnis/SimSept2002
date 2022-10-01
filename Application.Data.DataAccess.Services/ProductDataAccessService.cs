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
        public Product Create(Product enity)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(int id, Product enity)
        {
            throw new NotImplementedException();
        }
    }
}
