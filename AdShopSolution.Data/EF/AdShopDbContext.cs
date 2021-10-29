using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AdShopSolution.Data.Entities;

namespace AdShopSolution.Data.EF
{
    public class AdShopDbContext : DbContext
    {
        public AdShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
