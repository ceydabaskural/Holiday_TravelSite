using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Holiday_TravelSite.Models.Entities
{
    public class Home
    {
        [Key]
        public int HomePageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}