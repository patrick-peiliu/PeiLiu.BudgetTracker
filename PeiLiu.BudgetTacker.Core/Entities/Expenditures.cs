using System;
using System.ComponentModel.DataAnnotations;

namespace PeiLiu.BudgetTacker.Core.Entities
{
    public class Expenditures
    {
        
        public int Id { get; set; }
        public int UsersId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
        public DateTime? ExpDate { get; set; }

        [MaxLength(500)]
        public string Remarks { get; set; }

        // Navigation Properties
        public Users Users { get; set; }
    
    }
}
