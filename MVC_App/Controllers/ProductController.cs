using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Application.Model.Entities;
using Application.Data.Contract;
using Application.Data.DataAccess;
using Application.Data.DataAccess.Services;
using MVC_App.CustomValidationLogic;

namespace MVC_App.Controllers
{
    public class ProductController : Controller
    {
        IDbAccess<Product, int> prdServ;
        IDbAccess<Category, int> catServ;

        public ProductController()
        {
            prdServ = new ProductDataAccessService();
            catServ = new CategoryDataAccessService();
        }

        // GET: Product
        public ActionResult Index()
        {
            var result = prdServ.Get();
            return View(result);
        }

        public ActionResult Create()
        {
            var prd = new Product();
            ViewBag.CategoryUniqueId = new SelectList(catServ.Get(), "CategoryUniqueId", "CategoryName");
            return View(prd);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            var modelValidator = new CustomProductValidator();
            if (ModelState.IsValid)
            //if (modelValidator.Validate(product))
            {
                // Logic for Calculating Vat and Total Price

                product.Vat = product.Price * Convert.ToDecimal(0.08);
                product.TotalPrice = product.Price + product.Vat;

                var result = prdServ.Create(product);
                return RedirectToAction("Index");
            }
            else
            {
                // Stey on Same View or Page
                ViewBag.CategoryUniqueId = new SelectList(catServ.Get(), "CategoryUniqueId", "CategoryName");
                return View(product);
            }
        }

        public ActionResult Edit(int id)
        {
            var cat = prdServ.Get(id);
            // return an Edit View to show the Data to be Edited
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            var result = prdServ.Update(id, product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var cat = prdServ.Delete(id);
            // return an Edit View to show the Data to be Edited
            return RedirectToAction("Index");
        }
    }
}