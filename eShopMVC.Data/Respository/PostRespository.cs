using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IPostRespository : IRespository<Post>  {
        IEnumerable<Post> GetAllByTag(string tag, out int totalRow, int pageIndex, int pageSize);
    }
   public class PostRespository : RespositoryBase<Post>,IPostRespository
    {
        public PostRespository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<Post> GetAllByTag(string tag, out int totalRow, int pageIndex, int pageSize)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreateDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}
