using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.RepositoryInterfaces;
using PeiLiu.BudgetTacker.Infrastructure.Data;

namespace PeiLiu.BudgetTacker.Infrastructure.Repositories
{
    public class UserRepository : EFRepository<Users>, IUserRepository
    {
        public UserRepository(BudgetTrackerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Users> GetUserByName(string name)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.FullName == name);

        }
    }
}
