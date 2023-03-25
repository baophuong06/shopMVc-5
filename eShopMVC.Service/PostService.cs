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
   public interface  IPostService
    {
        Post Add(Post post);
        void Update(Post post);
       Post Delete(int id);
        Post GetByID(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllCategoryPaging(int categoryID,int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRespository _postIRes;
        IUnitOfWork _unitOfW;
        public PostService(IPostRespository _postRespository,IUnitOfWork _unitOfWork)
        {
            this._postIRes = _postRespository;
            this._unitOfW = _unitOfWork;
        }
        public Post Add(Post post)
        {
          return  _postIRes.Add(post);
        }

        public Post Delete(int id)
        {
           return _postIRes.Delete(id);
        }
       public Post GetByID(int id)
        {
            return _postIRes.GetSingleByID(id);
        }
        public IEnumerable<Post> GetAll()
        {
            return _postIRes.GetAll(new string[] { "PostCategorys" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postIRes.GetAllByTag(tag, out  totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postIRes.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public void SaveChanges()
        {
            _unitOfW.Commit();
        }

        public void Update(Post post)
        {
            _postIRes.Update(post);
        }

        public IEnumerable<Post> GetAllCategoryPaging(int categoryID, int page, int pageSize, out int totalRow)
        {
            return _postIRes.GetMultiPaging(x => x.CategoryID == categoryID, out totalRow, page, pageSize, new string[] { "PostCategorys" });
        }
    }
}
