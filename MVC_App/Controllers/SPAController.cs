using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class SPAController : Controller
    {
        // GET: SPA
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexSPA()
        {
            return View();
        }

        public ActionResult LoadListView()
        {
            return PartialView("LoadListView");
        }

        public ActionResult LoadCreateView()
        {
            return PartialView("LoadCreateView", new Category());
        }

    }
}