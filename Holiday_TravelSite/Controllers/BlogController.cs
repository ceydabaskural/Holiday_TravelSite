using Holiday_TravelSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holiday_TravelSite.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();

        BlogComment blogComment = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            blogComment.Value1 = c.Blogs.ToList();
            blogComment.Value3 = c.Blogs.Take(8).OrderByDescending(c => c.BlogId);
            blogComment.Value4 = c.Comments.Take(3).OrderByDescending(c => c.CommentId);
            return View(blogComment);
        }

        public ActionResult Detail(int id)
        {
            //var findBlog = c.Blogs.Where(x => x.BlogId == id).ToList();
            blogComment.Value1 = c.Blogs.Where(x => x.BlogId == id).ToList();
            blogComment.Value2 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(blogComment);
        }

        [HttpGet]
        public PartialViewResult PartialViewComment(int id)
        {
            ViewBag.value = id;
            return PartialView();

        }

        [HttpPost]
        public PartialViewResult PartialViewComment(Comment comment)
        {
            c.Comments.Add(comment);
            c.SaveChanges();
            return PartialView();
        }
    }
}