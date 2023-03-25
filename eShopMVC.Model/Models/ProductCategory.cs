using eShopMVC.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Model.Models
{
    [Table("ProductCategorys")]
  public  class ProductCategory : AudiTable
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
       
        //public decimal? Price { get; set; }
        //public decimal? PromotionPrice { get; set; }
        //public int? Warranty { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        //public string Content { get; set; }
        public bool? HomFlag { get; set; }
        //public bool? hotflag { get; set; }
        //public int viewcount { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
