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
    public class ExpenditureRepository : EFRepository<Expenditures>, IExpenditureRepository
    {
        public ExpenditureRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Expenditures>> GetExpendituresByUserId(int id)
        {
            var expenditures = await (from u in _dbContext.Users.Where(u => u.Id == id)
                                 join e in _dbContext.Expenditures
                                 on u.Id equals e.UsersId
                                 select e).ToListAsync();

            return expenditures;
        }
    }
}
