using ProductCategory.Domain.Aggregations.CategoryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ProductCategory.Domain.Repositories
{
    [ScopedService]
    public interface ICategoryRepository : Contract.Abstracts.IRepository<Category, int>
    {
        Task<Category> FindByTitleAsync(string categoryTitle);

    }
}
