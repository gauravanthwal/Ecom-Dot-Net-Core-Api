using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;        // e.g. "Admin", "Customer"
        public string? Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
