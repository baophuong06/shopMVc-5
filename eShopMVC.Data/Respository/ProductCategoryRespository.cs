using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IProductCategoryRespository : IRespository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetAlias(string alias); 
    }
    public class ProductCategoryRespository : RespositoryBase<ProductCategory>,IProductCategoryRespository
    {
        public ProductCategoryRespository(IDbFactory dbFactory) : base(dbFactory) { }

       public IEnumerable<ProductCategory> GetAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x=>x.Alias==alias);
        }
    }
}
