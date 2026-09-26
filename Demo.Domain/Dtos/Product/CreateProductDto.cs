using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Dtos.Product
{
    public class CreateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string? ImageUrl { get; set; }
        public Guid ProductCategoryId { get; set; }
    }
}
