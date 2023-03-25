using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IProductQuanlityResposirory: IRespository<ProductQuantity>
    {
    }
    public class ProductQuanlityResposirory : RespositoryBase<ProductQuantity>,IProductQuanlityResposirory
    {
        public ProductQuanlityResposirory(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
