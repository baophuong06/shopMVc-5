﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Model.Models
{
    [Table("OderDetails")]
   public class OrderDetail
    {
        [Key]
        [Column(Order =1)]
        public int OrderID { get; set; }
       [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Orders { get; set; }

    }
}
