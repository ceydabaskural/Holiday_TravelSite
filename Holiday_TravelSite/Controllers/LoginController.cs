using Holiday_TravelSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Holiday_TravelSite.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var information = c.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (information != null)
            {
                FormsAuthentication.SetAuthCookie(information.Username, false);
                Session["Username"]=information.Username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}