using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Data.Contract;
using Application.Model.Entities;
using Application.Data.DataAccess.Services;
using System.Web.Http.Results;

namespace API_App.Controllers
{
     
    public class SearchController : ApiController
    {
        IDbAccess<Category, int> catServ;
        IDbAccess<Product, int> prdServ;
        /// <summary>
        /// Injecting the dependencies
        /// </summary>
        /// <param name="catServ"></param>
        /// <param name="prdServ"></param>
        public SearchController(IDbAccess<Category, int> catServ, IDbAccess<Product, int> prdServ)
        {
            this.catServ = catServ;
            this.prdServ = prdServ;
        }
        /// <summary>
        /// Define a Custom Route
        /// </summary>
        /// <param name="catname"></param>
        /// <param name="condition">OR or AND Condition</param>
        /// <param name="prodname"></param>
        /// <returns></returns>
        [Route("search/{catname}/{condition}/{prodname}")]
        [HttpGet]
        public IHttpActionResult Search(string catname, string condition, string prodname)
        {
            List<Product> prods = new List<Product>();
            try
            { 
                // Reading Categoris and Producst
                var categories = catServ.Get();
                var products = prdServ.Get();

                // Get the CategoryUniqueId from catname

                var cat = categories.Where(c => c.CategoryName == catname).FirstOrDefault();
                if (cat == null)
                    throw new Exception($"Sorry, the category {catname} is missting");

                switch (condition)
                {
                    case "OR":
                        prods = (from prd in products
                                     where prd.CategoryUniqueId == cat.CategoryUniqueId || prd.ProductName == prodname
                                     select prd).ToList();

                        break;
                    case "AND":
                        prods = (from prd in products
                                     where prd.CategoryUniqueId == cat.CategoryUniqueId && prd.ProductName == prodname
                                     select prd).ToList();
                        break;
                    default:
                        return Ok();
                        
                }
                return Ok(prods);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }

        }
    }
}
