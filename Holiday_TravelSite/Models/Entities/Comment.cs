using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Holiday_TravelSite.Models.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Review { get; set; }
        public int BlogId { get; set; }

        //Bir blogun birden fazla yorumu olurken bir yorum sadece vir blog için geçerli olabilir bu yüzden ıcollection ı blog sayfasına yazdık:
        public virtual Blog Blog { get; set; } // yorum ekledikçe blog eklmemesi için bu propertynin virtual olmasını istedil
    }
}