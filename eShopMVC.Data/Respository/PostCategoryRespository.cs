using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IPostCategoryRespository : IRespository<PostCategory> { }
   public class PostCategoryRespository : RespositoryBase<PostCategory>,IPostCategoryRespository
    
    {
        public PostCategoryRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
