using eShopMVC.Data.Infrastructure;
using eShopMVC.Data.Respository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.UnitTest.RepositoryTest
{
    [TestClass]
  public  class ProductRepositoryTest
    {
        IUnitOfWork _unitOfWork;
         IDbFactory _dbFactory;
         IProductRespository _productRespository;
        [TestInitialize]
        public void Initial()
        {
            _dbFactory = new DbFactory();
            _unitOfWork = new UnitOfWork(_dbFactory);
            _productRespository = new ProductRespository(_dbFactory);

        }
        //[TestMethod]
        //public void Product_Respository_GetAll()
        //{
        //    var list = _productRespository.GetAll().ToList();
        //    Assert.AreEqual(2, list.Count());
        //}
    }
}
