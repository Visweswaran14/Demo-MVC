using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dotnet2.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is required")]
        [MinLength(4)]
        [MaxLength(20)]
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
