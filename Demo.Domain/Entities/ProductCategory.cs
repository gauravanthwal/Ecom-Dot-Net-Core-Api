using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Entities
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Navigation properties
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
