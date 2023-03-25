using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;

namespace eShopMVC.Model.Models
{
    [Table("Footers")]
  public  class Footer
    {
        [Key]
        public string ID{ get; set; }
        [AllowHtml]
        public string Content { get; set; }

    }
}
