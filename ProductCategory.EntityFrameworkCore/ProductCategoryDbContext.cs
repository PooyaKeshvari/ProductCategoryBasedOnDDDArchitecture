using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.EntityFrameworkCore
{
   public class ProductCategoryDbContext:IdentityDbContext<ApplicationUser>
    {
        #region [-Ctor-]
        public ProductCategoryDbContext(DbContextOptions<ProductCategoryDbContext> contextOptions):base(contextOptions)
        {

        }
        #endregion

        #region [-OnModelCreating()-]
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
        #endregion

        #region [-Aggregates-DbSet<>-]
        public DbSet<Domain.Aggregations.ProductAggregate.Product> Product { get; set; }
        public DbSet<Domain.Aggregations.CategoryAggregate.Category> Category{ get; set; }
        #endregion

    }
}
