using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IProductTagRespository:IRespository<ProductTag> { }
  public  class ProductTagRespository : RespositoryBase<ProductTag>,IProductTagRespository
    {
        public ProductTagRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
