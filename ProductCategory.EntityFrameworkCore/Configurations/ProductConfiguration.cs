using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCategory.Domain.Aggregations.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.EntityFrameworkCore.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(65);
            builder.Property(p => p.Quantity ).HasColumnType("decimal") ;
            builder.Property(p => p.UnitPrice ).HasColumnType("decimal") ;
            builder.HasOne(o => o.Category).WithMany(m => m.Products);
        }
    }
}
