
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopMVC.Web.Models
{
    public class ProductImageViewModel
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel Products { get; set; }
        public string Path { get; set; }
        public string Caption { get; set; }
    }
}