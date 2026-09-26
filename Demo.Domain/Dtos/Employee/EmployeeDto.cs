using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Domain.Dtos.Employee
{
    public class EmployeeDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }
        public string? Position { get; set; } = string.Empty;
        public DateTime? DOB { get; set; }

        [Required]
        [MaxLength(15)]
        public string? PhoneNumber { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string? City { get; set; }
    }
}
