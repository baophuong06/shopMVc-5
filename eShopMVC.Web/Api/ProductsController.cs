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
    [RoutePrefix("api/product")]
    public class ProductsController : ApiControllerBase
    {
        IProductService _iProductService;
        public ProductsController(IErrorService _errorService, IProductService productService) : base(_errorService)
        {
           this. _iProductService = productService;
        }
        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listProduct = _iProductService.GetAll();
                var listProductViewModel = Mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel>>(listProduct);
                _iProductService.SaveChanges();
                HttpResponseMessage reponse = request.CreateResponse(HttpStatusCode.OK, listProductViewModel);
                return reponse;
            });
             
        }
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request,ProductViewModel productVM)
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
                     Product p = new Product();
                     p.UpdateProduct(productVM);
                     var productAdd = _iProductService.Add(p);
                     _iProductService.SaveChanges();
                     response = request.CreateResponse(HttpStatusCode.Created, productAdd);
                 }
                 return response;
             });
        }
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request,ProductViewModel productViewModel)
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
                    var pr = _iProductService.GetByID(productViewModel.ID);
                    pr.UpdateProduct(productViewModel);
                    _iProductService.Update(pr);
                    _iProductService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        [HttpDelete]
        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request,int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                   
                    _iProductService.Delete(id);
                    _iProductService.SaveChanges();
                    reponse = request.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
    }
}
