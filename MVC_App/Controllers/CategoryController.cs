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
    public class CategoryController : Controller
    {
        IDbAccess<Category, int> catServ;

        public CategoryController()
        {
            catServ = new CategoryDataAccessService();
        }


        // GET: Category
        public ActionResult Index()
        {
            var result = catServ.Get();
            // Pass the Model to View So that the 
            // view will show data
            return View(result);
        }

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