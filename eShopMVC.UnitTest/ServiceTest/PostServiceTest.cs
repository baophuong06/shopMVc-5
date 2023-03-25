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
    public class PostServiceTest
    {
        private Mock<IPostRespository> _mockIPostRepository;
        private Mock<IUnitOfWork> _mockIUnitOfWork;
        private IPostService _iPostService;
        private List<Post> listPost;
        [TestInitialize]
        public void Initialize()
        {
            _mockIPostRepository = new Mock<IPostRespository>();
            _mockIUnitOfWork = new Mock<IUnitOfWork>();
            _iPostService = new PostService(_mockIPostRepository.Object, _mockIUnitOfWork.Object);
            listPost = new List<Post>()
            {
                new Post(){ID=1,Name="DM1" ,Alias="DM1",Status=true},
                new Post(){ID=2,Name="DM2" ,Alias="DM2",Status=true},
              new Post(){ID=3,Name="DM3" ,Alias="DM3",Status=true}
            };
        }
        [TestMethod]
        public void Post_Service_GetAll()
        {
            //setup method
            _mockIPostRepository.Setup(m=>m.GetAll(null)).Returns(listPost);
            //setup action
            var result=_iPostService.GetAll() as List<Post>;
            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        public void Post_Service_Create()
        {
            Post post = new Post();
            post.Name = "post name service";
            post.Alias = "post-name";
            post.Status = true;

            _mockIPostRepository.Setup(m => m.Add(post)).Returns((Post p) =>
              {
                  p.ID = 1;
                  return p;
              });
            var result = _iPostService.Add(post);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
        
    

