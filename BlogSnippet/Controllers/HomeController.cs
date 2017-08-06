using BlogSnippet.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            // Verify that the user selected a file
            if (model.ImageFile != null && model.ImageFile.ContentLength > 0)
            {
                var fileType = Path.GetExtension(model.ImageFile.FileName);
                var fileName = Guid.NewGuid().ToString() + fileType;

                // store the file inside ~/Images/Uploads folder
                var path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                model.ImageFile.SaveAs(path);

                // Save web url
                model.Image = Url.Content(string.Format("~/Images/Uploads/{0}", fileName));
            }

            using (var context = new BlogContext())
            {
                model.Created = DateTime.Now;
                context.BlogPosts.Add(model);
                context.SaveChanges();
            }

            TempData["success"] = true;

            return RedirectToAction("CreateBlogPost");
        }
    }
}