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
    public interface IPostTagService
    {
        PostTag Add(PostTag postTag);
        void Update(PostTag tag);
        PostTag Delete(int id);
        IEnumerable<PostTag> GetAll();
        PostTag GetByID(int ID);
        void Save();
    }
    public class PostTagService : IPostTagService
    {
        private IPostTagRespository _postTagRespository;
        private IUnitOfWork _unitOfWork;
        public PostTagService(IPostTagRespository postTagRespository,IUnitOfWork unitOfWork)
        {
            _postTagRespository = postTagRespository;
            _unitOfWork = unitOfWork;
        }
        public PostTag Add(PostTag postTag)
        {
            return _postTagRespository.Add(postTag);
        }

        public PostTag Delete(int id)
        {
            return _postTagRespository.Delete(id);
        }

        public IEnumerable<PostTag> GetAll()
        {
            return _postTagRespository.GetAll();
        }

        public PostTag GetByID(int ID)
        {
            return _postTagRespository.GetSingleByID(ID);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostTag tag)
        {
            _postTagRespository.Update(tag);
        }
    }
}
