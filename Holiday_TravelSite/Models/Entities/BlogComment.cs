﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holiday_TravelSite.Models.Entities
{
    public class BlogComment
    {
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Comment> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }
        public IEnumerable<Comment> Value4 { get; set; }

    }
}