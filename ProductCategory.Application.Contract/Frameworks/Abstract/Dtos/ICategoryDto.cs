using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Application.Contract.Frameworks.Abstract.Dtos
{
    public interface ICategoryDto
    {
        string CategoryTitle { get; set; }
        //ICollection<IProductDto> Products { get; set; }
    }
}
