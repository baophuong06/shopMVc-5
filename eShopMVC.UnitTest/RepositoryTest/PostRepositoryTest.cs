using eShopMVC.Data.Infrastructure;
using eShopMVC.Data.Respository;
using eShopMVC.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.UnitTest.RepositoryTest
{
    [TestClass]
  public  class PostRepositoryTest
    {
        IDbFactory _iDbFactory;
        IPostRespository _postRespository;
        IUnitOfWork _unitOfWork;
        [TestInitialize]
        public void Initialize()//IDbFactory dbFactory,IPostRespository postRespository,IUnitOfWork unitOfWork)
        {
            _iDbFactory = new DbFactory();
            _postRespository = new PostRespository(_iDbFactory);
            _unitOfWork = new UnitOfWork(_iDbFactory);
        }
        //[TestMethod]
        //public void Post_Repository_GetAll()
        //{
        //    var list = _postRespository.GetAll().ToList();
        //    Assert.AreEqual(2, list.Count);
        //}
        [TestMethod]
        public void Post_Repository_Create()
        {
            Post post = new Post();
            post.Name = "Post Name Category";
            post.Alias = "Post-Name";
            post.Status = true;
            post.CategoryID = 1;
            var result = _postRespository.Add(post);
            _unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
