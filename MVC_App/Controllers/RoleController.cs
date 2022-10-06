using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class RoleController : Controller
    {
      
        ApplicationDbContext context;
        ApplicationUserManager userManager;
        public RoleController()
        {
            // this will allow ro aceess roles, creates roles, as well as managed them
            context = new ApplicationDbContext();
        }

       

        // GET: Role
        public ActionResult Index()
        {
            var roles  = context.Roles.ToList();
            return View(roles);
        }

        public ActionResult Create()
        {
            var role = new IdentityRole();
            return View(role); 
        }
        [HttpPost]
        public ActionResult Create(IdentityRole role)
        {
            context.Roles.Add(role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //public ActionResult AssignRoleToUser()
        //{
        //    UserRoles userRoles = new UserRoles();
        //    // Get All USers and Roles
        //    userRoles.Users = context.Users.ToList();
        //    userRoles.Roles = context.Roles.ToList();
        //    return View(userRoles);
        //}
        //[HttpPost]
        //public ActionResult AssignRoleToUser(UserRoles userRoles)
        //{
        //    return RedirectToAction("Index");
        //}
    }
}