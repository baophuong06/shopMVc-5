
using AutoMapper;
using eShopMVC.Model.Models;
using eShopMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopMVC.Web.Mappings
{
    //public class AutoMapperProfile : Profile
    //{
    //    public AutoMapperProfile()
    //    {

    //        //var config = new MapperConfiguration(cfg =>
    //        //{
    //        CreateMap<Post, PostViewModel>();
    //        CreateMap<PostCategory, PostCategoryViewModel>();
    //        CreateMap<Tag, TagViewModel>();
    //        CreateMap<Product, ProductViewModel>();
    //        CreateMap<ProductTag, ProductTagViewModel>();
    //        CreateMap<ProductCategory, ProductCategoryViewModel>();
    //        CreateMap<Feedback, FeedbackViewModel>();
    //        //});
    //        ////Mapper.CreateMap
    //    }
    //}
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
                //cfg.CreateMap<Footer, FooterViewModel>();
                //cfg.CreateMap<Slide, SlideViewModel>();
                //cfg.CreateMap<Page, PageViewModel>();
                //cfg.CreateMap<ContactDetail, ContactDetailViewModel>();
                //cfg.CreateMap<AppRole, ApplicationRoleViewModel>();
                //cfg.CreateMap<AppUser, AppUserViewModel>();
                //cfg.CreateMap<Function, FunctionViewModel>();
                //cfg.CreateMap<Permission, PermissionViewModel>();
                cfg.CreateMap<ProductImage, ProductImageViewModel>();
                cfg.CreateMap<ProductQuantity, ProductQuantityViewModel>();
                cfg.CreateMap<Color, ColorViewModel>();
                cfg.CreateMap<Size, SizeViewModel>();
                //cfg.CreateMap<Order, OrderViewModel>();
                //cfg.CreateMap<OrderDetail, OrderDetailViewModel>();
                //cfg.CreateMap<Announcement, AnnouncementViewModel>();
                //cfg.CreateMap<AnnouncementUser, AnnouncementUserViewModel>();
            });
        }
    }
}