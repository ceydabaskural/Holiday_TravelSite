using Holiday_TravelSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holiday_TravelSite.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            c.Contacts.Add(contact);
            c.SaveChanges();
            return PartialView();
        }
    }
}