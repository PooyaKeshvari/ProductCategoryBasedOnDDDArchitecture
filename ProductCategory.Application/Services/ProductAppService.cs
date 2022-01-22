using AutoMapper;
using ProductCategory.Application.Abstracts;
using ProductCategory.Application.Dtos;
using ProductCategory.Domain.Aggregations.ProductAggregate;
using ProductCategory.Domain.Factories;
using ProductCategory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Application.Services
{
    public class ProductAppService : Abstracts.IProductAppService
    {

        #region [-Ctor-]
        public ProductAppService(ProductFactoryService factory, IProductRepository repository, IMapper mapper)
        {
            Factory = factory;
            Repository = repository;
            Mapper = mapper;
        }
        #endregion

        #region [-Props-]
        public Domain.Factories.ProductFactoryService Factory { get; set; }
        public Domain.Repositories.IProductRepository Repository { get; set; }
        public IMapper Mapper { get; set; }
        #endregion

        #region [-Tasks-]

        #region [-DeleteAsync(Guid id)-]
        public async Task DeleteAsync(Guid id)
        {
            await Repository.DeleteAsync(id);
        }
        #endregion

        #region [-GetByIdAsync(Guid id)-]
        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var target = await Repository.FindByIdAsync(id);
            return Mapper.Map<ProductDto>(target);
        }
        #endregion

        #region [-PostAsync(ProductDto entity)-]
        public async Task<ProductDto> PostAsync(ProductDto entity)
        {
            var checkAndNew = Factory.DtoConvertor(entity); 
            await Repository.InsertAsync(checkAndNew);
            return Mapper.Map<ProductDto>(checkAndNew);
        }
        #endregion

        #region [-GetAll()-]
        public async Task<List<ProductDto>> GetAll()
        {
            var q = await Repository.Select();
            return Mapper.Map<List<ProductDto>>(q);
        }
        #endregion

        #region [-PutAsync(ProductDto entity)-]
        public async Task PutAsync(Guid id, ProductDto entity)
        {
            var product = await Repository.FindByIdAsync(id);
            if (product != null)
            {
                
                product.Title = entity.Title;
                product.CategoryId = entity.CategoryId;
                product.Quantity = entity.Quantity;
                product.UnitPrice = entity.UnitPrice;
                await Repository.UpdateAsync(product);
            }


        }
        #endregion

        #endregion


    }
}
