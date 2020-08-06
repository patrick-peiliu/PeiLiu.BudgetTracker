using System;
using System.ComponentModel.DataAnnotations;

namespace PeiLiu.BudgetTacker.Core.Models.Request
{
    public class UserRequestModel
    {
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        public string FullName { get; set; }

    }
}
