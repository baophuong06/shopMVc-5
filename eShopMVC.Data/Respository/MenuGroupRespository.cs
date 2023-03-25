using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IMenuGroupRespository : IRespository<MenuGroup> { }
   public class MenuGroupRespository : RespositoryBase<MenuGroup>,IMenuGroupRespository
    {
        public MenuGroupRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
