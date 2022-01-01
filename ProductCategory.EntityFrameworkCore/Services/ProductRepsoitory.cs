using Microsoft.EntityFrameworkCore;
using ProductCategory.Domain.Aggregations.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.EntityFrameworkCore.Services
{
    public class ProductRepsoitory : Frameworks.Base.BaseRepository<ProductCategoryDbContext, Product, Guid>,
         Domain.Repositories.IProductRepository
    {

        #region [-Ctor-]
        public ProductRepsoitory(ProductCategoryDbContext context) : base(context)
        {

        }
        #endregion

        #region [-Methods-]
        public async Task<Product> FindByTitle(string title)
        {
            var target = await DbSet.FirstOrDefaultAsync(q => q.Title == title);
            return target;
        }
        #endregion




    }
}
