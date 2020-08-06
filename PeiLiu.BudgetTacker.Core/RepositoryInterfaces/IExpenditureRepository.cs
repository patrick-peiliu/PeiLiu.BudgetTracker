using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;

namespace PeiLiu.BudgetTacker.Core.RepositoryInterfaces
{
    public interface IExpenditureRepository : IAsyncRepository<Expenditures>
    {
        Task<IEnumerable<Expenditures>> GetExpendituresByUserId(int id);
    }
}
