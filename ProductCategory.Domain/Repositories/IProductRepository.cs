using ProductCategory.Domain.Aggregations.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ProductCategory.Domain.Repositories
{
    [ScopedService]
    public interface IProductRepository : Contract.Abstracts.IRepository<Product, Guid>
    {
         Task<Product> FindByTitle(string title);
    }
}
