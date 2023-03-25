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
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentID(int parentID);
        PostCategory GetByID(int id);
        void Save();
    }
  public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRespository _postCategoryRespository;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRespository postCategoryRespository,IUnitOfWork unitOfWork)
        {
            this._postCategoryRespository = postCategoryRespository;
            this._unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
         return   _postCategoryRespository.Add(postCategory);
        }

        public PostCategory Delete(int id)
        {
           return _postCategoryRespository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRespository.GetAll();//new string[] { "PostCategory" });
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentID)
        {
           return _postCategoryRespository.GetMulti(x => x.Status && x.ParentID == parentID);
        }

        public PostCategory GetByID(int id)
        {
            return _postCategoryRespository.GetSingleByID(id);
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }
        public void Update(PostCategory postCategory)
        {
            _postCategoryRespository.Update(postCategory);
        }
    }
}
