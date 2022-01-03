using Microsoft.AspNetCore.Mvc;
using ProductCategory.Application.Abstracts;
using ProductCategory.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCategory.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region [-Ctor-]
        public CategoryController(ICategoryAppService appService)
        {
            AppService = appService;
        }
        #endregion

        #region [-Props-]
        public Application.Abstracts.ICategoryAppService AppService { get; set; }
        #endregion

        #region [-Actions-]

        #region [-GetAllAsync()-]
        [Route("wapi/v1/1")]
        [HttpGet]
        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var q = AppService.GetAll();
            return await q;
        }
        #endregion

        #region [-PostAsync()-]
        [Route("wapi/v1/2")]
        [HttpPost]
        public async Task<CategoryDto> PostAsync(CategoryDto category)
        {
            var q = AppService.PostAsync(category);
            return await q;
        }
        #endregion

        #region [-PutAsync()-]
        [Route("wapi/v1/3")]
        [HttpPut]
        public async Task PutAsync(int id, CategoryDto category)
        {
            await AppService.PutAsync(id, category);
        }
        #endregion

        #region [-DeleteAsync()-]
        [Route("wapi/v1/4")]
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await AppService.DeleteAsync(id);
        }
        #endregion

        #region [-GetByIdAsync-]
        [Route("wapi/v1/5")]
        [HttpGet]
        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var q = await AppService.GetByIdAsync(id);
            return q;
        }
        #endregion

        #endregion


    }
}
