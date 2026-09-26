using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Persistency.Configurations
{
    public class ProductCategoryConfiguration: IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");

            builder.HasKey(pc => pc.Id);

            builder.Property(pc => pc.Name).IsRequired().HasMaxLength(150);
            builder.Property(pc => pc.Description).HasMaxLength(500);

            builder.HasMany(pc => pc.Products)
               .WithOne(p => p.ProductCategory)
               .HasForeignKey(p => p.ProductCategoryId)
               .OnDelete(DeleteBehavior.Restrict); // don't delete products if a category is removed
        }
    }
}
