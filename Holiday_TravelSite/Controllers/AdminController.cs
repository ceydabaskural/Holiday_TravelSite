using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Holiday_TravelSite.Models.Entities;
using Context = Holiday_TravelSite.Models.Entities.Context;

namespace Holiday_TravelSite.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var value = c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetailBlog(int id)
        {
            var detail = c.Blogs.Where(x=>x.BlogId==id).FirstOrDefault();
            return View (detail);
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var blogs = c.Blogs.Find(id);
            return View("UpdateBlog", blogs);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var value = c.Blogs.Find(blog.BlogId);
            value.Description = blog.Description;
            value.Title= blog.Title;
            value.ImageUrl= blog.ImageUrl;
            value.Date= blog.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var comments = c.Comments.Find(id);
            c.Comments.Remove(comments);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var comment = c.Comments.Find(id);
            return View("UpdateComment", comment);
        }

        [HttpPost]
        public ActionResult UpdateComment(Comment comment)
        {
            var value = c.Comments.Find(comment.CommentId);
            value.Username = comment.Username;
            value.Review = comment.Review;
            value.Mail = comment.Mail;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult AboutList()
        {
            var about = c.Abouts.ToList();
            return View(about);
        }

        public ActionResult DeleteAbout(int id)
        {
            var about = c.Abouts.Find(id);
            c.Abouts.Remove(about);
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = c.Abouts.Find(id);
            return View("UpdateAbout", about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = c.Abouts.Find(about.AboutId);
            value.ImageUrl = about.ImageUrl;
            value.Description = about.Description;
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }


        public ActionResult ContactList()
        {
            var contacts = c.Contacts.ToList();
            return View(contacts);
        }

        public ActionResult DeleteContact(int id)
        {
            var contacts = c.Contacts.Find(id);
            c.Contacts.Remove(contacts);
            c.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}