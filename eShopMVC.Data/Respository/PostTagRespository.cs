using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IPostTagRespository : IRespository<PostTag> { }
 public   class PostTagRespository : RespositoryBase<PostTag>,IPostTagRespository
    {
        public PostTagRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
