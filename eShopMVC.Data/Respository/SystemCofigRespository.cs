using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface ISystemCofigRespository:IRespository<SystemCofig>
    { }
    public class SystemCofigRespository : RespositoryBase<SystemCofig>,ISystemCofigRespository
    {
        public SystemCofigRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
