using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopMVC.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { set; get; }

       
        public string Name { set; get; }

        
        public string Alias { set; get; }

        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
        public int HomeOrder { get; set; }

        public virtual IEnumerable<ProductViewModel> Product { set; get; }

        public DateTime? CreateBy { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        
        public bool Status { set; get; }
    }
}