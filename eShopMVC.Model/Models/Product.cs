using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShopMVC.Model.Abstract;
using System.Xml.Linq;

namespace eShopMVC.Model.Models
{

    [Table("Products")]
   public class Product : AudiTable
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public string Image { get; set; }
        [Column(TypeName="xml")]
        public string MoreImage { get; set; }
        public decimal? Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
