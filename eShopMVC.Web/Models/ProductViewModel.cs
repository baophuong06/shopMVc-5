using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopMVC.Web.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public string Image { get; set; }
       
        public string MoreImage { get; set; }
        public decimal? Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
       
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool Status { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }

        public virtual ProductCategoryViewModel ProductCategory { get; set; }
    }
}