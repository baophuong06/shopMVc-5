using eShopMVC.Model.Models;
using eShopMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopMVC.Web.Infracstructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory,PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.CreateDate = postCategoryViewModel.CreatedDate;
            postCategory.CreateBy = postCategoryViewModel.CreatedBy;
            postCategory.UpdateDate = postCategoryViewModel.UpdatedDate;
            postCategory.UpdateBy = postCategoryViewModel.UpdatedBy;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.Status = postCategoryViewModel.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.CategoryID = postViewModel.CategoryID;
            post.Image = postViewModel.Image;
            post.Description = postViewModel.Description;
            post.Content = postViewModel.Content;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotFlag = postViewModel.HotFlag;
            post.ViewCount = postViewModel.ViewCount;
            post.CreateDate = postViewModel.CreatedDate;
            post.CreateBy = postViewModel.CreatedBy;
            post.UpdateDate = postViewModel.UpdatedDate;
            post.UpdateBy = postViewModel.UpdatedBy;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.MetaDescription = postViewModel.MetaDescription;
            post.Status = postViewModel.Status;
        }

        public static void UpdateProduct(this Product p, ProductViewModel productViewModel)
        {
            p.ID = productViewModel.ID;
            p.Name = productViewModel.Name;
            p.Alias = productViewModel.Alias;
            p.CategoryID = productViewModel.CategoryID;
            p.Image = productViewModel.Image;
            p.MoreImage = productViewModel.MoreImage;
            p.Description = productViewModel.Description;
            p.Content = productViewModel.Content;
            p.HomFlag = productViewModel.HomFlag;
            p.HotFlag = productViewModel.HotFlag;
            p.ViewCount = productViewModel.ViewCount;
            p.CreateDate = productViewModel.CreateDate;
            p.CreateBy = productViewModel.CreateBy;
            p.UpdateDate = productViewModel.UpdateDate;
            p.UpdateBy = productViewModel.UpdateBy;
            p.MetaKeyword = productViewModel.MetaKeyword;
            p.MetaDescription = productViewModel.MetaDescription;
            p.Status = productViewModel.Status;
            p.Price = productViewModel.Price;
            p.PromotionPrice = productViewModel.PromotionPrice;
            p.Warranty = productViewModel.Warranty;
        }
        public static void UpdateProductCategory(this ProductCategory productCategory,ProductCategoryViewModel productCategoryViewModel)
        {
            productCategory.ID = productCategoryViewModel.ID;
            productCategory.Name = productCategoryViewModel.Name;
            productCategory.Alias = productCategoryViewModel.Alias;
            productCategory.ParentID = productCategoryViewModel.ParentID;
            productCategory.DisplayOrder = productCategoryViewModel.DisplayOrder;
            productCategory.Image = productCategoryViewModel.Image;
            productCategory.Description = productCategoryViewModel.Description;
            productCategory.HomFlag = productCategoryViewModel.HomeFlag;
            productCategory.CreateDate = productCategoryViewModel.CreateBy;
            productCategory.CreateBy = productCategoryViewModel.CreatedBy;
            productCategory.UpdateDate = productCategoryViewModel.UpdatedDate;
            productCategory.UpdateBy = productCategoryViewModel.UpdatedBy;
            productCategory.MetaKeyword = productCategoryViewModel.MetaKeyword;
            productCategory.MetaDescription = productCategoryViewModel.MetaDescription;
            productCategory.Status = productCategoryViewModel.Status;
        }
        public static void UpdateFeedback(this Feedback feedback,FeedbackViewModel feedbackViewModel)
        {
            feedback.Name = feedbackViewModel.Name;
            feedback.Email = feedbackViewModel.Email;
            feedback.Message = feedbackViewModel.Message;
            feedback.Status = feedbackViewModel.Status;
            feedback.CreatedDate = DateTime.Now;
           
        }
        public static void UpdateProductImage(this ProductImage productImage,ProductImageViewModel productImageViewModel)
        {
            productImage.ID = productImageViewModel.ID;
            productImage.ProductId = productImageViewModel.ProductId;
            productImage.Path = productImageViewModel.Path;
            productImage.Caption = productImageViewModel.Caption;
        }
        public static void UpdateQuantityProduct(this ProductQuantity productQuantity,ProductQuantityViewModel productQuantityViewModel)
        {
            productQuantity.ColorId = productQuantityViewModel.ColorId;
            productQuantity.ProductId = productQuantityViewModel.ProductId;
            productQuantity.Quantity = productQuantityViewModel.Quantity;
            productQuantity.SizeId = productQuantityViewModel.SizeId;
        }
    }
}