using System;
using AdShopSolution.Data.Enums;
using System.Collections.Generic;
using AdShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of AdShop" },
                new AppConfig() { Key = "HomeKeyWord", Value = "This is key word of AdShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of AdShop" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },

                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },

                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men"
                },

                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ"
                },

                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt products for women",
                    SeoTitle = "The shirt products for women"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                }
            );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam Việt Hoàng",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-viet-hoang",
                    SeoDescription = "Sản phẩm áo sơ mi thời trang nam",
                    SeoTitle = "Sản phẩm áo sơ mi thời trang nam",
                    Details = "Sản phẩm áo sơ mi thời trang nam",
                    Description = "Sản phẩm áo sơ mi thời trang nam"
                },

                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Hoang Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viet-hoang-men-t-shirt",
                    SeoDescription = "The T-Shirt products for men",
                    SeoTitle = "The T-Shirt products for men",
                    Details = "The T-Shirt products for men",
                    Description = "The T-Shirt products for men"
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
            );
        }
    }
}
