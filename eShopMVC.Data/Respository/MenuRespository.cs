using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IMenuRespository : IRespository<Menu>
    { }
   public class MenuRespository : RespositoryBase<Menu>,IMenuRespository
    {
        public MenuRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
