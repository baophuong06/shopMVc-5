using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IProductRespository:IRespository<Product>
    {
       
    }
   public class ProductRespository : RespositoryBase<Product>,IProductRespository
    {
        public ProductRespository(IDbFactory dbFactory) : base(dbFactory) { }//phuong thuc khoi tao de tao ra duy nhat 1 dbContext
    }
}
