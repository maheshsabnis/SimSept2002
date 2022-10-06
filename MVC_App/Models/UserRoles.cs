using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class UserRoles
    {
        public List<ApplicationUser> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public string User { get; set; }
        public string Role { get; set; }
    }
}