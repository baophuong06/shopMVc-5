using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
  public interface IAppUserRespository:IRespository<AppUser>
    {
    }
    public class AppUserRespository : RespositoryBase<AppUser>, IAppUserRespository
    {
        public AppUserRespository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
