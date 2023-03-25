using eShopMVC.Data.Infrastructure;
using eShopMVC.Data.Respository;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Service
{
    public interface IAnnouncementService
    {
        Announcement Create(Announcement announcement);
        List<Announcement> GetListByUserId(string userId, int pageIndex, int pageSize, int totalRow);
        List<Announcement> GetListByUserId(string userId, int top);

        void Delete(int notificationId);

        void MarkAsRead(string userId, int notificationId);

        Announcement GetDetail(int id);

        List<Announcement> GetListAll(int pageIndex, int pageSize, out int totalRow);

        List<Announcement> ListAllUnread(string userId, int pageIndex, int pageSize, out int totalRow);

        void Save();
    }
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementRespository _announcementRespository;
        private readonly IAnnouncementUserRespository _announcementUserRespository;
        private readonly UnitOfWork _unitOfWork;
    public AnnouncementService(IAnnouncementRespository announcementRespository,
        IAnnouncementUserRespository announcementUserRespository,UnitOfWork unitOfWork)
        {
            _announcementRespository = announcementRespository;
            _announcementUserRespository = announcementUserRespository;
            _unitOfWork = unitOfWork;
        }
        public Announcement Create(Announcement announcement)
        {
            return _announcementRespository.Add(announcement);
        }

        public void Delete(int notificationId)
        {
            _announcementRespository.Delete(notificationId);
        }

        public Announcement GetDetail(int id)
        {
            return _announcementRespository.GetSingleByCondition(x => x.ID == id, new string[] { "AppUser" });
        }

        public List<Announcement> GetListAll(int pageIndex, int pageSize, out int totalRow)
        {
            var query = _announcementRespository.GetAll(new string[] { "AppUser"});
            totalRow = query.Count();
            return query.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Announcement> GetListByUserId(string userId, int pageIndex, int pageSize, int totalRow)
        {
            var query = _announcementRespository.GetMulti(x => x.UserId == userId);
            totalRow = query.Count();
            return query.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    

        public List<Announcement> GetListByUserId(string userId, int top)
        {
          return  _announcementRespository.GetMulti(x => x.UserId == userId).OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }

        public List<Announcement> ListAllUnread(string userId, int pageIndex, int pageSize, out int totalRow)
        {
            var query = _announcementRespository.GetAllUnread(userId);
            totalRow = query.Count();
            return query.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public void MarkAsRead(string userId, int notificationId)
        {
            var announ = _announcementUserRespository.GetSingleByCondition(x => x.AnnouncementId == notificationId && x.UserId == userId);
            if(announ==null)
            {
                 _announcementUserRespository.Add(new AnnouncementUser()
                {
                    AnnouncementId = notificationId,
                    UserId = userId,
                    HasRead = true
                });
            }
            else
            {
                announ.HasRead = true;
            }
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
