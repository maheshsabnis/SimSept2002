using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Model.Entities;
using Application.Data.Contract;
using Application.Data.DataAccess;
using Application.Data.DataAccess.Services;

namespace MVC_App.Controllers
{
    /// <summary>
    /// Only Authorizing the user1
    /// </summary>
  //  [Authorize(Users ="user1@msit.com")]
    public class CategoryController : Controller
    {
        IDbAccess<Category, int> catServ;

        public CategoryController()
        {
            catServ = new CategoryDataAccessService();
        }


        // GET: Category
       // [Authorize(Roles = "Manager,Clerk,Operator")]
        public ActionResult Index()
        {
            var result = catServ.Get();
            // Pass the Model to View So that the 
            // view will show data
            return View(result);
        }
        /// <summary>
        /// Only Secure the Create Action and hence all actions those are initated using the Create.cshtml 
        /// </summary>
        /// <returns></returns>
        //   [Authorize]
   //     [Authorize(Roles = "Manager,Clerk")]
        public ActionResult Create()
        {
            var cat = new Category();
            return View(cat);
        }

        [HttpPost]
        public ActionResult Create(Category category)
        { 
            var result = catServ.Create(category);
            return RedirectToAction("Index");
        }
     //   [Authorize(Roles = "Manager,Clerk")]
        public ActionResult Edit(int id)
        {
            var cat = catServ.Get(id);
            // return an Edit View to show the Data to be Edited
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(int id,Category category)
        {
            var result = catServ.Update(id, category);
            return RedirectToAction("Index");
        }
     //   [Authorize(Roles = "Manager")]
        public ActionResult Delete(int id)
        {
            var cat = catServ.Delete(id);
            // return an Edit View to show the Data to be Edited
            return RedirectToAction("Index");
        }


        public ActionResult ShowProducts(int id)
        { 
            Category cat = catServ.Get(id);
            TempData["Category"] = cat;


            // Save id in TempData
            TempData["CategoryUniqueId"] = id;
            // Redirect to Index Veiw Of the Prtoduct Controller
            return RedirectToAction("Index", "Product");
        }
    }
}