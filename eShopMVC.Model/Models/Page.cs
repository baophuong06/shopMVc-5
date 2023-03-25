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
    [Table("Pages")]
  public  class Page : AudiTable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
        [AllowHtml]
        public string Content { get; set; }

    }
}
