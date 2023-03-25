using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eShopMVC.Model.Models
{
    [Table("ProductTags")]
   public class ProductTag
    {
        [Key]
        [Column(Order =1)]
        public int ProductID { get; set; }
        [Key]
        [Column(TypeName ="varchar",Order =2)]
        public string TagID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }
    }
}
