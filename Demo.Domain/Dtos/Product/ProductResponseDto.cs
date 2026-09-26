using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Dtos.Product
{
    public class ProductResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string? ImageUrl { get; set; }

        public Guid ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; } = string.Empty; // flattened, not the whole category object
    }
}
