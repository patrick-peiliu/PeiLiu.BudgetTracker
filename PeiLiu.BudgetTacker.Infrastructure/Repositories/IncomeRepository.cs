using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.RepositoryInterfaces;
using PeiLiu.BudgetTacker.Infrastructure.Data;

namespace PeiLiu.BudgetTacker.Infrastructure.Repositories
{
    public class IncomeRepository : EFRepository<Incomes>, IIncomeRepository
    {
        public IncomeRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Incomes>> GetIncomesByUserId(int id)
        {
            var incomes = await (from u in _dbContext.Users.Where(u => u.Id == id)
                                 join i in _dbContext.Incomes
                                 on u.Id equals i.UsersId
                                 select i).ToListAsync();

            return incomes;
        }
    }
}
