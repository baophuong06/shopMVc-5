namespace eShopMVC.Data.Migrations
{
    using eShopMVC.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eShopMVC.Data.DBShopMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eShopMVC.Data.DBShopMVCContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
        private void CreateProductCategorySample(eShopMVC.Data.DBShopMVCContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Áo nam",Alias="ao-nam",Status=true },
                    new ProductCategory() { Name="Áo nữ",Alias="ao-nu",Status=true },
                    new ProductCategory() { Name="Giày nam",Alias="giay-nam",Status=true },
                    new ProductCategory() { Name="Giày nữ",Alias="giay-nu",Status=true }
                };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}
