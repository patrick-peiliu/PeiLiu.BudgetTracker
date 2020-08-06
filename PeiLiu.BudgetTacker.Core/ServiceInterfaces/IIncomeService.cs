using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.Models.Request;

namespace PeiLiu.BudgetTacker.Core.ServiceInterfaces
{
    public interface IIncomeService
    {
        Task<IEnumerable<Incomes>> GetIncomesByUserId(int id);
        Task<Incomes> AddIncome(IncomeRequestModel incomeRequestModel);
    }
}
