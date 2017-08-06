using BlogSnippet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new BlogContext();
            ViewBag.Blogs = context.BlogPosts.ToList();

            return View();
        }
        
        public ActionResult CreateBlogPost()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult CreateBlogPost(BlogPost model)
        {
            using (var context = new BlogContext())
            {
                model.Created = DateTime.Now;
                context.BlogPosts.Add(model);
                context.SaveChanges();
            }

            return View();
        }
    }
}