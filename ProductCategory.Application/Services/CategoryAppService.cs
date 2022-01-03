using AutoMapper;
using ProductCategory.Application.Dtos;
using ProductCategory.Domain.Factories;
using ProductCategory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCategory.Application.Services
{
    public class CategoryAppService : Abstracts.ICategoryAppService
    {

        #region [-Ctor-]
        public CategoryAppService(CategoryFactoryService factory, ICategoryRepository repository, IMapper mapper)
        {
            Factory = factory;
            Repository = repository;
            Mapper = mapper;
        }
        #endregion

        #region [-Props-]
        public Domain.Factories.CategoryFactoryService Factory { get; set; }
        public Domain.Repositories.ICategoryRepository Repository { get; set; }
        public IMapper Mapper { get; set; }
        #endregion

        #region [-Tasks-]

        #region [-DeleteAsync(Guid id)-]
        public async Task DeleteAsync(int id)
        {
            await Repository.DeleteAsync(id);
        }
        #endregion

        #region [-GetByIdAsync(Guid id)-]
        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var target = await Repository.FindByIdAsync(id);
            return Mapper.Map<CategoryDto>(target);
        }
        #endregion

        #region [-PostAsync(ProductDto entity)-]
        public async Task<CategoryDto> PostAsync(CategoryDto entity)
        {
            var checkAndNew = await Factory.CheckThenCreateAsync(entity.CategoryTitle);
            await Repository.InsertAsync(checkAndNew);
            return Mapper.Map<CategoryDto>(checkAndNew);
        }
        #endregion

        #region [-GetAll()-]
        public async Task<List<CategoryDto>> GetAll()
        {
            var q = await Repository.Select();
            return Mapper.Map<List<CategoryDto>>(q);
        }
        #endregion

        #region [-PutAsync(ProductDto entity)-]
        public async Task PutAsync(int id, CategoryDto entity)
        {
            var category = await Repository.FindByIdAsync(id);
            if (category != null)
            {
                category.CategoryTitle = entity.CategoryTitle;
                await Repository.UpdateAsync(category);
            }


        }
        #endregion

        #endregion


    }
}
