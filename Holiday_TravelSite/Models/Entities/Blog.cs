
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Holiday_TravelSite.Models.Entities
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}