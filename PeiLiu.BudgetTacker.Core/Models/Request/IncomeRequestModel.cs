using System;
using System.ComponentModel.DataAnnotations;

namespace PeiLiu.BudgetTacker.Core.Models.Request
{
    public class IncomeRequestModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string Description { get; set; }
    }
}
