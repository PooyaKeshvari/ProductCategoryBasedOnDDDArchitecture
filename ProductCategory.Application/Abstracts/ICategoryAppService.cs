using ProductCategory.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ProductCategory.Application.Abstracts
{

    [ScopedService]
    public interface ICategoryAppService
    {

        Task<CategoryDto> PostAsync(CategoryDto entity);
        Task PutAsync(int id, CategoryDto entity);
        Task DeleteAsync(int id);
        Task<List<CategoryDto>> GetAll();
        Task<CategoryDto> GetByIdAsync(int id);


    }

}
