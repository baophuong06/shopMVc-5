using eShopMVC.Data.Infrastructure;
using eShopMVC.Data.Respository;
using eShopMVC.Model.Models;
using eShopMVC.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.UnitTest.ServiceTest
{
    [TestClass]
 public  class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRespository> _mockPostCategory;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> _listPostCategory;
        [TestInitialize]
        public void Initialize()
        {
            _mockPostCategory = new Mock<IPostCategoryRespository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _postCategoryService = new PostCategoryService(_mockPostCategory.Object, _mockUnitOfWork.Object);
            _listPostCategory = new List<PostCategory>() 
            { new PostCategory() {ID=1,Name="DM1",Status=true },
              new PostCategory() {ID=2,Name="DM2",Status=true },
              new PostCategory() {ID=3,Name="DM3",Status=true }
            };
        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            _mockPostCategory.Setup(m => m.GetAll(null)).Returns(_listPostCategory);
            var result = _postCategoryService.GetAll() as List<PostCategory>;
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            

        }

    }
}
