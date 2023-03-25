using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IProductImageResposirory : IRespository<ProductImage>
    {
    }
    public class ProductImageResposirory : RespositoryBase<ProductImage>, IProductImageResposirory
    {
        public ProductImageResposirory(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
