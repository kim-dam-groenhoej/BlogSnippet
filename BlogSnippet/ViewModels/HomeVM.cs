using BlogSnippet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSnippet.ViewModels
{
    public class HomeVM
    {
        public List<BlogPost> Blogs { get; set; }
    }
}