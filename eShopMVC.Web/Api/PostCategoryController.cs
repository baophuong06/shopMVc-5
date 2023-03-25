using AutoMapper;
using eShopMVC.Model.Models;
using eShopMVC.Service;
using eShopMVC.Web.Infracstructure.Core;
using eShopMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eShopMVC.Web.Infracstructure.Extensions;
namespace eShopMVC.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService _errorService, IPostCategoryService postCategoryService) : base(_errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        // GET api/<controller>
        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
               
                    var listCategory = _postCategoryService.GetAll();
                    var listPostCategoryVM = Mapper.Map<List<PostCategoryViewModel>>(listCategory);
                    _postCategoryService.Save();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVM);
                
                return response;
            });


        }
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryVM)
        {
            return CreateHttpResponse(request, () =>
            {
                 HttpResponseMessage response = null;
                 if(ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                    PostCategory postCategory = new PostCategory();
                    postCategory.UpdatePostCategory(postCategoryVM);
                   var category= _postCategoryService.Add(postCategory);
                    _postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, category);
                 }
                return response;
             });
             

        }
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCateDb = _postCategoryService.GetByID(postCategoryVM.ID);
                    postCateDb.UpdatePostCategory(postCategoryVM);
                    _postCategoryService.Update(postCateDb);
                    _postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });


        }
        [HttpDelete]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });


        }

    }
}