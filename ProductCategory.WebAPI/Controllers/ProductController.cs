using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCategory.Application.Abstracts;
using ProductCategory.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCategory.WebAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region [-Ctor-]
        public ProductController(IProductAppService appService)
        {
            AppService = appService;
        }
        #endregion

        #region [-Props-]
        public Application.Abstracts.IProductAppService AppService { get; set; }
        #endregion

        #region [-Actions-]

        #region [-GetAllAsync()-]
        [Route("wapi/v1/1")]
        [HttpGet]
        public async Task<List<ProductDto>> GetAllAsync()
        {
            var q = AppService.GetAll();
            return await q;
        }
        #endregion

        #region [-PostAsync()-]
        [Route("wapi/v1/2")]
        [HttpPost]
        public async Task<ProductDto> PostAsync(ProductDto product)
        {
            var q = AppService.PostAsync(product);
            return await q;
        }
        #endregion

        #region [-PutAsync()-]
        [Route("wapi/v1/3")]
        [HttpPut]
        public async Task PutAsync(Guid id,ProductDto product)
        {
             await AppService.PutAsync(id,product);
        }
        #endregion

        #region [-DeleteAsync()-]
        [Route("wapi/v1/4")]
        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await AppService.DeleteAsync(id);
        }
        #endregion

        #region [-GetByIdAsync-]
        [Route("wapi/v1/5")]
        [HttpGet]
        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
           var q = await AppService.GetByIdAsync(id);
            return q;
        }
        #endregion

        #endregion


    }
}
