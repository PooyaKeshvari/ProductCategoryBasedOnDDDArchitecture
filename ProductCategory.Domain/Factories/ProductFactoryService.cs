using ProductCategory.Application.Contract.Frameworks.Abstract.Dtos;
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

        #region [-CheckThenCreateAsync(string title,int categoryId, decimal qty, decimal unitPrice)-]
        public virtual async Task<Product> CheckThenCreateAsync(string title, int categoryId, decimal qty, decimal unitPrice)
        {
            var current = await ProductRepository.FindByTitle(title);
            if (current == null)
            {
                return new Product(title, categoryId, qty, unitPrice);
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region [-DtoConvertor(IProductDto productController)-]
        public Product DtoConvertor(IProductDto productController)
        {
            var model = new Product();
            model.Id = productController.Id;
            model.Title = productController.Title;
            model.CategoryId = productController.CategoryId;
            model.UnitPrice = productController.UnitPrice;
            model.Quantity = productController.Quantity;
            return model;
        }
        #endregion

        #endregion

    }
}
