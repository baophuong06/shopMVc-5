using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Model.Models
{
    [Table("Sizes")]
  public  class Size
    {
        public int ID { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
    }
}
