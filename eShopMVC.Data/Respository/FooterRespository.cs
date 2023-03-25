using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IFooterRespository : IRespository<Footer>
    { }
   public class FooterRespository : RespositoryBase<Footer>,IFooterRespository
    {
        public FooterRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
