using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BlogSnippet.Models
{
    public class BlogPost
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name ="Titel")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Indhold", ResourceType = typeof(Ressources.Resource1))]
        [AllowHtml]
        public string Content { get; set; }

        [Required]
        [Display(Name ="Dato")]
        public DateTime Created { get; set; }

        [Display(Name = "Billede")]
        public string Image { get; set; }
    }
}