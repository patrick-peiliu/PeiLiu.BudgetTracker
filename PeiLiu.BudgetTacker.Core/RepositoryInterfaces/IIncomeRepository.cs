using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;

namespace PeiLiu.BudgetTacker.Core.RepositoryInterfaces
{
    public interface IIncomeRepository : IAsyncRepository<Incomes>
    {
        Task<IEnumerable<Incomes>> GetIncomesByUserId(int id);
    }
}
