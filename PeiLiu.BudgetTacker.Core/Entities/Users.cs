using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeiLiu.BudgetTacker.Core.Entities
{
    public class Users
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string Password { get; set; }

        [MaxLength(10)]
        public string FullName { get; set; }

        public DateTime? JoinedOn { get; set; }

        public ICollection<Incomes> Incomes { get; set; }
        public ICollection<Expenditures> Expenditures { get; set; }
    }
}
