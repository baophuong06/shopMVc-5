using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Model.Models
{
  public  class SystemCofig
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="Varchar")]
        [MaxLength(50)]
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
    }
}
