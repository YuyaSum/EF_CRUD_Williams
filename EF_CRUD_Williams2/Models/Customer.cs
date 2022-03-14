using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_CRUD_Williams2.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        [MaxLength (40)]
        public string FirstName { get; set; } = null!;
        [MaxLength(40)]
        public string LastName { get; set; } = null!;
        [MaxLength(40)]
        public string? City { get; set; }
        [MaxLength(40)]
        public string? Country { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
    }
}
