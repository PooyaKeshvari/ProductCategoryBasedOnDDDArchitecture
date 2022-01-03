using ProductCategory.Application.Contract.Frameworks.Abstract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Application.Contract.Frameworks.Base.Dtos
{
    public class BaseProductDto : Abstract.Dtos.IProductDto
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
     
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public Guid? Id { get ; set ; }
        ICategoryDto IProductDto.CategoryDto { get ; set; }
    }
}
