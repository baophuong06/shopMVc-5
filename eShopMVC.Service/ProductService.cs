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
   public interface IProductService
    {
        Product Add(Product product);
        void Update(Product product);
        Product Delete(int productId);
        Product GetByID(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllCategoryByID(int categoryID, int page, int pageSize, out int totalRow);

       // IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        IProductRespository _iProductRepository;
        IUnitOfWork _unitOfWork;
        public ProductService(IProductRespository productRespository,IUnitOfWork unitOfWork)
        {
            _iProductRepository = productRespository;
            _unitOfWork = unitOfWork;
        }
        public Product Add(Product product)
        {
            return _iProductRepository.Add(product);
        }

        public Product Delete(int productId)
        {
            return _iProductRepository.Delete(productId);
        }

        public IEnumerable<Product> GetAll()
        {
            return _iProductRepository.GetAll();
        }

        public IEnumerable<Product> GetAllCategoryByID(int categoryID, int page, int pageSize, out int totalRow)
        {
            return _iProductRepository.GetMultiPaging(x => x.CategoryID == categoryID, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _iProductRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Product GetByID(int id)
        {
            return _iProductRepository.GetSingleByID(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _iProductRepository.Update(product);
        }
    }
}
