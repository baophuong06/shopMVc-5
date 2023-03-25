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
    public interface IProductCategoryService
    {
        ProductCategory Add(ProductCategory productCategory);
        void Update(ProductCategory productCategory);
        ProductCategory Delete(int id);
        IEnumerable<ProductCategory> GetAll();
        IEnumerable<ProductCategory> GetAllPage(int pageIndex, int PageSize);
        IEnumerable<ProductCategory> GetAllKey(string keyword);
        IEnumerable<ProductCategory> GetAllByParentId(int parentId);
       ProductCategory GetById(int Id);
        void Save();
    }
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRespository _productCategoryRespository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRespository productCategoryRespository,IUnitOfWork unitOfWork)
        {
            _productCategoryRespository = productCategoryRespository;
            _unitOfWork = unitOfWork;
        }
        public ProductCategory Add(ProductCategory productCategory)
        {
            return _productCategoryRespository.Add(productCategory);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryRespository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRespository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllByParentId(int parentId)
        {
            var query = _productCategoryRespository.GetMulti(x => x.Status && x.ParentID == parentId);
            return query;
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryRespository.GetSingleByID(id);
        }
        public void Update(ProductCategory productCategory)
        {
            _productCategoryRespository.Update(productCategory);
        }

        public IEnumerable<ProductCategory> GetAllPage( int page, int PageSize)
        {
            //var query=_productCategoryRespository.g

            var search = _productCategoryRespository.GetAll().OrderBy(x=>x.Name);//.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword))


           // var totalRow = search.Count();
            return search.Skip(page * PageSize).Take(PageSize);

        }

        public IEnumerable<ProductCategory> GetAllKey(string keyword)
        {
            if(!string.IsNullOrEmpty(keyword))
            {
                var query = _productCategoryRespository.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword))
                .OrderBy(x => x.ParentID);
                return query;
            }
            else
            {
                return _productCategoryRespository.GetAll().OrderBy(x => x.ParentID);
            }
        }
    }
}
