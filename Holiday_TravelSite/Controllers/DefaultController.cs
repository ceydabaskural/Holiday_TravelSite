using Holiday_TravelSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holiday_TravelSite.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Blogs.Take(8).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.BlogId).Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var values = context.Blogs.Take(10).ToList();
            return PartialView(values);
        } 
        public PartialViewResult Partial4() //blog partial sol taraf
        {
            var values = context.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5() //blog partial sağ taraf
        {
            var values = context.Blogs.Take(3).OrderByDescending(x=>x.BlogId).ToList();
            return PartialView(values);
        }
    }
}