using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        // FK — 1:1 with User
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        // Navigation
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

    public class CartItem
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }

        public Guid CartId { get; set; }
        public Cart Cart { get; set; } = null!;

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
