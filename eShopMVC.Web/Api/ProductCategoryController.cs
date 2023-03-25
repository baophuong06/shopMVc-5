using eShopMVC.Service;
using eShopMVC.Web.Infracstructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AutoMapper;
using eShopMVC.Web.Models;
using eShopMVC.Model.Models;
using eShopMVC.Web.Infracstructure.Extensions;
using System.Data.Entity.Validation;

namespace eShopMVC.Web.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
       private IProductCategoryService _productCategoryService;
        public ProductCategoryController(IErrorService errorService,IProductCategoryService productCategoryService)
            : base(errorService) {
           this. _productCategoryService = productCategoryService;
        }
        [Route("getall")]
        [HttpGet]
       
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listproductCategory = _productCategoryService.GetAll();
                var listPostCategoryVM = Mapper.Map<IEnumerable<ProductCategory> ,IEnumerable<ProductCategoryViewModel>>(listproductCategory);
               _productCategoryService.Save();
                var response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVM);

                return response;
            });

        }

        [Route("getallparent")]
        [HttpGet]
        
        public HttpResponseMessage GetAllParent(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                
                var listPC = _productCategoryService.GetAll();
               
                var query = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(listPC);
                _productCategoryService.Save();
                response = request.CreateResponse(HttpStatusCode.OK, query);
                return response;
            });
        }
        [Route("getallpage")]
        [HttpGet]
        
        public HttpResponseMessage GetAllPage(HttpRequestMessage request,int page=0,int pageSize=2)
        {
            return CreateHttpResponse(request, () =>
            {
               // HttpResponseMessage response = null;
                int totalRow = 0;
                var listPC = _productCategoryService.GetAll();
                totalRow = listPC.Count();
                var query = listPC.OrderBy(x => x.Name).Skip(page * pageSize).Take(pageSize);
                var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(query);
                var pagination = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = responseData,
                   
                    Page = page,
                    TotalCount = totalRow,
                    TotalPages = (int)Math.Ceiling((decimal)totalRow / pageSize)
                };
               var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }
        [Route("create")]
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Create(HttpRequestMessage request,ProductCategoryViewModel productCategoryViewModel)
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
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.UpdateProductCategory(productCategoryViewModel);
                    productCategory.CreateDate = DateTime.Now;
                   _productCategoryService.Add(productCategory);
                    _productCategoryService.Save();
                    var responseData = Mapper.Map<ProductCategory, ProductCategoryViewModel>(productCategory);
                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                return response;
            });
        }
        [Route("getbyid")]
        [HttpGet]
        public HttpResponseMessage GetById(HttpRequestMessage request,int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
               
                var listPC = _productCategoryService.GetById(id);
              
                var responseData = Mapper.Map<ProductCategory,ProductCategoryViewModel>(listPC);

               // _productCategoryService.Save();
                response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
                
            });
        }
        [Route("edit/{id}")]
        [HttpPut]
        
        public HttpResponseMessage Edit(HttpRequestMessage request,ProductCategoryViewModel productCategoryViewModel)
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
                    if(productCategoryViewModel.ID==productCategoryViewModel.ParentID)
                    {
                        response = request.CreateResponse(HttpStatusCode.BadRequest, "Danh mục này không thể làm con chính nó.k");
                    }
                    var productCategory = _productCategoryService.GetById(productCategoryViewModel.ID);
                    //ProductCategory productCategory = new ProductCategory();
                    productCategory.UpdateProductCategory(productCategoryViewModel);
                    productCategory.UpdateDate = DateTime.Now;
                    _productCategoryService.Update(productCategory);
                   
                    try
                    {
                        _productCategoryService.Save();
                    }
                    catch(DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }
                    var updateProductCategory = Mapper.Map<ProductCategory, ProductCategoryViewModel>(productCategory);
                    response = request.CreateResponse(HttpStatusCode.Created, updateProductCategory);
                }
                return response;
            });
        }
        [Route("delete")]
        [HttpDelete]
        
        public HttpResponseMessage Delete(HttpRequestMessage request,int Id)
        {
            HttpResponseMessage response = null;
            return CreateHttpResponse(request, () =>
            {
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var productDelete = _productCategoryService.GetById(Id);
                    _productCategoryService.Save();

                    var responseData = Mapper.Map<ProductCategory, ProductCategoryViewModel>(productDelete);
                    response = request.CreateResponse(HttpStatusCode.OK, responseData);
                    
                }
                return response;
            });
        }
    }
}
