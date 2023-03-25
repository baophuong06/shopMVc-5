using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShopMVC.Model.Abstract;
using System.Web.Mvc;

namespace eShopMVC.Model.Models
{
    [Table("Posts")]
  public  class Post : AudiTable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
    
        public int CategoryID { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategorys { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }

    }
}
