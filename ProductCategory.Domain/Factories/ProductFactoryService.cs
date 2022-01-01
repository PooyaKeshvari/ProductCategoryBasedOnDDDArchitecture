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
    public class ProductFactoryService
    {
        #region [-Ctor-]
        public ProductFactoryService()
        {

        }
        #endregion

        #region [-Props-]
        public Repositories.IProductRepository ProductRepository { get; set; }
        #endregion

        #region [-Methods-]
        public virtual async Task<Product> CheckThenCreateAsync(string title,Category category, decimal qty, decimal unitPrice)
        {
            var current = await ProductRepository.FindByTitle(title);
            if (current == null)
            {
                return new Product(title,category, qty, unitPrice);
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
