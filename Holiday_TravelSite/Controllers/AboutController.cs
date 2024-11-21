using Holiday_TravelSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holiday_TravelSite.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Abouts.ToList();
            return View(value);
        }
    }
}