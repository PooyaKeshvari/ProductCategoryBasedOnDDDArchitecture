using ProductCategory.Domain.Aggregations.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Domain.Aggregations.CategoryAggregate
{
    public class Category : Frameworks.Base.BaseEntityInt
    {

        #region [-Ctor-]
        public Category()
        {

        }
        public Category(string categoryTitle)
        {
            CategoryTitle = categoryTitle;
        }
        #endregion

        #region [-Props-]
        public string CategoryTitle { get; set; }
        public ICollection<ProductAggregate.Product> Products { get; set; }
        #endregion


    }
}
