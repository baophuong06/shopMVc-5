using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopMVC.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { get; set; }
        public int TagID { get; set; }
        public virtual PostViewModel Post { get; set; }
        public virtual TagViewModel Tag { get; set; }
    }
}