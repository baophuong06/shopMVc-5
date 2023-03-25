using eShopMVC.Data.Infrastructure;

using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
   public interface IFunctionRespository : IRespository<Function>
    {
        List<Function> GetListFunctionWithPermission(string userId);
    }
    public class FunctionRespository:RespositoryBase<Function>,IFunctionRespository
    {
        public FunctionRespository(DbFactory dbFactory) : base(dbFactory) { }

        public List<Function> GetListFunctionWithPermission(string userId)
        {
            var query= (from f in DbContext.Functions
                       join p in DbContext.Permissions on f.ID equals p.FunctionId
                       join r in DbContext.AppRoles on p.RoleId equals r.Id
                       join ur in DbContext.UserRoles on r.Id equals ur.RoleId
                       join u in DbContext.Users on ur.RoleId equals u.Id
                       where u.Id == userId && (p.CanRead == true)
                       select f);
            var parentIds = query.Select(x => x.ParentId).Distinct();
            query = query.Union(DbContext.Functions.Where(f => parentIds.Contains(f.ID)));
            return query.ToList();
        }
    }

}
