using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
  public  interface IPesmissionRespository : IRespository<Permission>
    {
        List<Permission> GetByUserId(string userId);
    }
    public class PermissionResposirory : RespositoryBase<Permission>, IPesmissionRespository
    {
        public PermissionResposirory(DbFactory dbFactory) : base(dbFactory) { }
        public List<Permission> GetByUserId(string userId)
        {
            var query = from f in DbContext.Functions
                        join p in DbContext.Permissions on f.ID equals p.FunctionId
                        join r in DbContext.AppRoles on p.RoleId equals r.Id
                        join ur in DbContext.UserRoles on r.Id equals ur.RoleId
                        join u in DbContext.Users on ur.RoleId equals u.Id
                        where u.Id == userId
                        select p;
            return query.ToList();
        }
    }
}
