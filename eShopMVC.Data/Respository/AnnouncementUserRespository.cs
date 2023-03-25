using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
   public interface IAnnouncementUserRespository : IRespository<AnnouncementUser>
    {
    }
    public class AnnouncementUserRespository : RespositoryBase<AnnouncementUser>, IAnnouncementUserRespository
    {
        public AnnouncementUserRespository(DbFactory dbFactory) : base(dbFactory) { }

    }
}
