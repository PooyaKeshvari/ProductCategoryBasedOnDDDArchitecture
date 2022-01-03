using ProductCategory.Application.Contract.Frameworks.Abstract.Dtos;
using System.Collections.Generic;

namespace ProductCategory.Application.Contract.Frameworks.Base.Dtos
{
    public class BaseCategoryDto : Abstract.Dtos.ICategoryDto
    {
        public string CategoryTitle { get ; set ; }
        //public ICollection<IProductDto> Products { get; set ; }
    }
}
