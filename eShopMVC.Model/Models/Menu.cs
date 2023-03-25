using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Model.Models
{
    [Table("Menus")]
  public  class Menu
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
        public int GroupID { get; set; }
        public string Target { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<MenuGroup> MenuGroups { get; set; }
    }
}
