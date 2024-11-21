﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Holiday_TravelSite.Models.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}