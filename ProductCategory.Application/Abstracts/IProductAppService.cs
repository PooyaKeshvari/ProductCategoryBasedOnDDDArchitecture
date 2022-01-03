using ProductCategory.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ProductCategory.Application.Abstracts
{
    [ScopedService]
    public interface IProductAppService
    {

        Task<ProductDto> PostAsync(ProductDto entity);
        Task PutAsync(Guid id,ProductDto entity);
        Task DeleteAsync(Guid id);
        Task<List<ProductDto>> GetAll();
        Task<ProductDto> GetByIdAsync(Guid id);

            
    }
}
