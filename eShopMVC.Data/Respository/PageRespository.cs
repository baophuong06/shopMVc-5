using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IPageRespository : IRespository<Page> { }
   public class PageRespository : RespositoryBase<Page>,IPageRespository
    {
        public PageRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
