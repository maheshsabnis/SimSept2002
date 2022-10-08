using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Data.Contract;
using Application.Model.Entities;
using Application.Data.DataAccess.Services;
using System.Web.Http.Cors;

namespace API_App.Controllers
{
    /// <summary>
    /// Lets Inject the Service Dependencies in the constructor
    /// http://localhost:44344/api/Category
    /// </summary>
    /// 
    [EnableCors("*", "*", "*")]
    public class CategoryController : ApiController
    {
        private readonly IDbAccess<Category, int> catServ;

        /// <summary>
        /// Inject Here, the instance will be injected by the DI Container
        /// </summary>
        public CategoryController(IDbAccess<Category, int> cat)
        {
            catServ = cat;
        }

        public IHttpActionResult Get()
        { 
            var data = catServ.Get();   
            return Ok(data);
        }

        public IHttpActionResult Get(int id)
        {
            var data = catServ.Get(id);
            return Ok(data);
        }

        /// <summary>
        /// https://localhost:44344/api/Category/
        /// The category will be passed in HTTP POST request in Body
        /// in JSON format and then the JSON from HTTP request will
        /// be mapped with Category CLR object by the ApiController class
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>

        public IHttpActionResult Post(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (IsCategoryIdExist(category.CategoryId))
                        throw new Exception($"The Category Id {category.CategoryId} is already exist");
                    var data = catServ.Create(category);
                    return Ok(data);
                }
                else
                {
                    // Return a Detailed Error Message
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// https://localhost:44344/api/Category/1
        /// PUT Request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public IHttpActionResult Put(int id,Category category)
        {
            try
            {
                if (id != category.CategoryUniqueId)
                    throw new Exception($"Category Unique id in Header does not match with data send in body");
                if (ModelState.IsValid)
                {
                    //if (IsCategoryIdExist(category.CategoryId))
                    //    throw new Exception($"The Category Id {category.CategoryId} is already exist");
                    var data = catServ.Update(id,category);
                    return Ok(data);
                }
                else
                {
                    // Return a Detailed Error Message
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// The delete request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var data = catServ.Delete(id);
                return Ok("The delete is successful");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private bool IsCategoryIdExist(string catId)
        {
            bool isExist = false;
            var cat = catServ.Get().Where(c=>c.CategoryId == catId).FirstOrDefault();    
            if(cat != null) isExist = true; 
            return isExist;
        }
    }
}
