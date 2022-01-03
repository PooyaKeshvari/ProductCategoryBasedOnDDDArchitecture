using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Application.Contract.Frameworks.Abstract.Dtos
{
   public interface IProductDto
    {
         Guid? Id { get; set; }
        string Title { get; set; }
        ICategoryDto CategoryDto { get; set; }
        int CategoryId { get; set; }
        decimal UnitPrice { get; set; }
        decimal Quantity { get; set; }
    }
}
