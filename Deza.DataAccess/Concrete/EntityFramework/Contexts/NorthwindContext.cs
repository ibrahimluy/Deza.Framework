using Deza.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Deza.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        public static IConfigurationRoot Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();

            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory()) // requires Microsoft.Extensions.Configuration.Json
                   .AddJsonFile("appsettings.json") // requires Microsoft.Extensions.Configuration.Json
                   .AddEnvironmentVariables(); // requires Microsoft.Extensions.Configuration.EnvironmentVariables

            Configuration = builder.Build();

            var sqlConn = Configuration.GetConnectionString("NorhwindConnection");

            optionsBuilder.UseSqlServer(sqlConn);

            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
