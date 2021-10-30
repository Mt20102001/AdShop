using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AdShopSolution.Data.EF
{
    public class AdShopSolutionDbContext : IDesignTimeDbContextFactory<AdShopDbContext>
    {
        public AdShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AdShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<AdShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AdShopDbContext(optionsBuilder.Options);
        }
    }
}
