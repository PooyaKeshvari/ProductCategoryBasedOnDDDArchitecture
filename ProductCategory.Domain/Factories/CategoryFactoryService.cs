using ProductCategory.Domain.Aggregations.CategoryAggregate;
using ProductCategory.Domain.Aggregations.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ProductCategory.Domain.Factories
{
    [ScopedService]
   public class CategoryFactoryService
    {

        #region [-Ctor-]
        public CategoryFactoryService(Repositories.ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }
        #endregion

        #region [-Props-]
        public Repositories.ICategoryRepository CategoryRepository{ get; set; }
        #endregion

        #region [-Methods-]
        public virtual async Task<Category> CheckThenCreateAsync(string title)
        {
            var current =await CategoryRepository.FindByTitleAsync(title);
            if (current==null)
            {
                return new Category(title);
            }
            else
            {
                return null;
            }
        }
        #endregion



    }
}
