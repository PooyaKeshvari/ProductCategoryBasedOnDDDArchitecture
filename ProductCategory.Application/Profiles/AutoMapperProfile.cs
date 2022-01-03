using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Application.Profiles
{
    public class AutoMapperProfile:Profile
    {
        #region [-Ctor-]
        public AutoMapperProfile()
        {
            //ProductFlow
            CreateMap<Domain.Aggregations.ProductAggregate.Product, Dtos.ProductDto>().ReverseMap();
            //CategoryFlow
            CreateMap<Domain.Aggregations.CategoryAggregate.Category, Dtos.CategoryDto>().ReverseMap();
        }
        #endregion

    }
}
