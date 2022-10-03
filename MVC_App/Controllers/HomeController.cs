using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    /// <summary>
    /// The Word Controller is scaffolded by MVC Request Processing and
    /// This will be filtered-out in Http Request
    /// http://server/Home
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// http://server/Home/Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// http://server/Home/About
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        /// <summary>
        /// http://server/Home/Contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}