using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace eShopMVC.Data.Respository
{
   public interface IAnnouncementRespository : IRespository<Announcement>
    {
        IQueryable<Announcement> GetAllUnread(string userId);
    }
    public class AnnouncementRespository : RespositoryBase<Announcement>, IAnnouncementRespository
    {
        public AnnouncementRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IQueryable<Announcement> GetAllUnread(string userId)
        {
            var query = (from x in DbContext.Announcements
                         join y in DbContext.AnnouncementUsers
                         on x.ID equals y.AnnouncementId
                         into xy
                         from y in xy.DefaultIfEmpty()
                         where(y.HasRead == false)
                         && (y.UserId == null || y.UserId == userId)
                         select x).Include(x => x.AppUser);
            return query;
        }
    }
}
