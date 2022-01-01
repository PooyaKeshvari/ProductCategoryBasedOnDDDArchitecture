using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCategory.Domain.Aggregations.CategoryAggregate;

namespace ProductCategory.EntityFrameworkCore.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CategoryTitle).IsRequired().HasMaxLength(50);
            builder.HasMany(m => m.Products);
        }
    }
}
