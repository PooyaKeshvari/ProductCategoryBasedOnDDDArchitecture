using ProductCategory.Domain.Aggregations.CategoryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Domain.Aggregations.ProductAggregate
{
    public class Product : Frameworks.Base.BaseEntityGuid
    {

        #region [-Ctor-]
        public Product(string title, Category category, decimal unitPrice, decimal quantity)
        {
            Title = title;
            Category = category;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
        #endregion

        #region [-Props-]
        public string Title { get; set; }
        public CategoryAggregate.Category Category { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        #endregion


    }
}
