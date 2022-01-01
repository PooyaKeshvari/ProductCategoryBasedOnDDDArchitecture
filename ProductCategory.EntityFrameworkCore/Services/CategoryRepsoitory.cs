using Microsoft.EntityFrameworkCore;
using ProductCategory.Domain.Aggregations.CategoryAggregate;
using System.Threading.Tasks;

namespace ProductCategory.EntityFrameworkCore.Services
{
    public class CategoryRepsoitory : Frameworks.Base.BaseRepository<ProductCategoryDbContext, Category, int>,
        Domain.Repositories.ICategoryRepository
    {

        #region [-Ctor-]
        public CategoryRepsoitory(ProductCategoryDbContext context) : base(context)
        {

        }
        #endregion

        #region [-Methods-]
        public async Task<Category> FindByTitleAsync(string categoryTitle)
        {
            var target = await DbSet.FirstOrDefaultAsync(q => q.CategoryTitle == categoryTitle);
            return target;
        }
        #endregion




    }
}
