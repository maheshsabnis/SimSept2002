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
using MVC_App.CustomActionFilters;
using System.Web.Routing;

namespace MVC_App.Controllers
{
    /// <summary>
    /// Applying ActionFilter at Controller Level
    /// </summary>
    //[LogFilter]
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
            List<Product> products = new List<Product>();

            // 1. Read data from TempData
            var cat = TempData["Category"];
            int id = Convert.ToInt32(TempData["CategoryUniqueId"]);
            if (id != 0)
            {
                products = prdServ.Get().Where(p=>p.CategoryUniqueId == id).ToList();
            }
            else
            {
                products = prdServ.Get().ToList();
            }
            // Keep the data uin TempData before sending result (Response) to CLient
            TempData.Keep();
            return View(products);
        }
        // The Custom Attribute for Action Filter

      //  [LogFilter()]
        public ActionResult Create()
        {
            // Check if the Data is still There in TempData
            int id = Convert.ToInt32(TempData["CategoryUniqueId"]);
            var prd = new Product();
            ViewBag.CategoryUniqueId = new SelectList(catServ.Get(), "CategoryUniqueId", "CategoryName");
            return View(prd);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            //try
            //{
                var modelValidator = new CustomProductValidator();
                if (ModelState.IsValid)
                //if (modelValidator.Validate(product))
                {
                    // Check if the Product is already available
                     var prd  = prdServ.Get().Where(p=>p.ProductId == product.ProductId).FirstOrDefault();
                    if (prd != null)
                        throw new Exception($"ProductId={product.ProductId} is already available");
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
           // }
            //catch (Exception ex)
            //{
            //    // Ctach the exception and return an error page from Views/Shared/Error.cshtml
            //    // return View("Error", new HandleErrorInfo(ex,"Product","Create") );

            //    return View("Error", new HandleErrorInfo(ex, RouteData.Values["controller"].ToString(), RouteData.Values["action"].ToString()));
            //}
        }
        /// <summary>
        /// This method will be called for any of the Action Method in 
        /// the Current Controller if it throws ann exception
        /// </summary>
        /// <param name="filterContext"></param>
        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    // 1. Set the Exception As Handleed so that the request Procesing will be stopped
        //    filterContext.ExceptionHandled = true;
        //    // 2. Get the Exception Object
        //    Exception ex = filterContext.Exception;

        //    // 3. Set the ViewResult
        //    ViewResult result = new ViewResult();
        //    result.ViewName = "Error";
        //    // 3.a. Create a ViewDataDictionary to pass data to View
        //    var viewData = new ViewDataDictionary();
        //    viewData["ExceptionMessage"] = ex.Message;
        //    RouteData route = filterContext.RouteData;
        //    viewData["ControllerName"] = route.Values["controller"].ToString();
        //    viewData["ActionName"] = route.Values["action"].ToString();
        //    // 3.b. Pass teh ViewData to the ViewData proeprty of the ViewResult classs
        //    result.ViewData = viewData;
        //    // 4. Set the Result
        //    filterContext.Result = result;

        //}

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